using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardReportSystem
{
    public partial class Form1 : Form
    {
        //車データを入れるバインディングリスト
        BindingList<Card> cards = new BindingList<Card>();
        BigPicture bigPicture = new BigPicture();

        private string FileName = "";
        private int SelectRow;
        string color;
        string cost;
        string ErrorText;

        public Form1()
        {
            InitializeComponent();
            //dgvCardDate.DataSource = cards;
            dgvCardDate.AllowUserToAddRows = false;
            dgvCardDate.Columns[0].Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (dgvCardDate.Columns.Contains(tbCardName.Text))
            {
                ErrorMessage(6);
            }
            if (dtpData.Text == "" || cbCardType.Text == "" || tbCardName.Text == "" || tbCardEffect.Text == "" || cbExpansion.Text == "" || cbRare.Text == "" || tbHave.Text == "")
            {
                ErrorMessage(1);
            }
            else
            {
                RadioSet();

                AddData(color, cost);//チェックされているラジオボタンの分を変数に代入してある
                TextErase();
                dgvCardDate.ClearSelection();
                SelectRow = -1;

                RadioReset();
            }
        }

        private void RadioReset()
        {
            var RadioButtonChecked_InGroup = gbColor.Controls.OfType<RadioButton>()
            .SingleOrDefault(rb => rb.Checked == true);
            RadioButtonChecked_InGroup.Checked = false;

            var RadioButtonChecked_Cost = gbCost.Controls.OfType<RadioButton>()
            .SingleOrDefault(rb => rb.Checked == true);
            RadioButtonChecked_Cost.Checked = false;
        }

        private void RadioSet()
        {
            var RadioButtonChecked_InGroup = gbColor.Controls.OfType<RadioButton>()
            .SingleOrDefault(rb => rb.Checked == true);
            color = RadioButtonChecked_InGroup.Text;

            var RadioButtonChecked_Cost = gbCost.Controls.OfType<RadioButton>()
            .SingleOrDefault(rb => rb.Checked == true);
            cost = RadioButtonChecked_Cost.Text;
        }

        private void TextErase()
        {
            tbCardName.Text = null;
            cbCardType.Text = null;
            tbCardEffect.Text = null;
            pbCardImage.Image = null;
        }

        private void AddData(string color,string cost)
        {


            Card card = new Card();
            card.time = dtpData.Value;
            card.type = cbCardType.Text;
            switch (color)
            {
                case "赤":
                    card.color = CardColor.赤;
                    break;
                case "青":
                    card.color = CardColor.青;
                    break;
                case "緑":
                    card.color = CardColor.緑;
                    break;
                case "白":
                    card.color = CardColor.白;
                    break;
                case "黒":
                    card.color = CardColor.黒;
                    break;
                case "無":
                    card.color = CardColor.無;
                    break;
            }
            card.name = tbCardName.Text;
            card.Effect = tbCardEffect.Text;
            dgvCardDate.CurrentRow.Cells[7].Value = ImageToByteArray(pbCardImage.Image);
            card.Expansion = cbExpansion.Text;
            switch (cost)
            {
                case "1":
                    card.Cost = "1";
                    break;
                case "2":
                    card.Cost = "2";
                    break;
                case "3":
                    card.Cost = "3";
                    break;
                case "4":
                    card.Cost = "4";
                    break;
                case "5":
                    card.Cost = "5";
                    break;
                case "6":
                    card.Cost = "6";
                    break;
                case "7":
                    card.Cost = "7";
                    break;
                case "8":
                    card.Cost = "8";
                    break;
                case "9":
                    card.Cost = "9";
                    break;
                case "10+":
                    card.Cost = "10+";
                    break;
            }
            card.Rarity = cbRare.Text;
            card.Have = int.Parse(tbHave.Text);
            cards.Insert(0, card);

            //メーカーをコンボボックスの入力候補に登録
            setComboBoxMaker(cbExpansion.Text);
        }

        private void setComboBoxMaker(string Expansion)
        {
            if (!cbExpansion.Items.Contains(Expansion))
            {
                cbExpansion.Items.Add(Expansion);
            }
        }

        private void ErrorMessage(int num)
        {
            ErrorText="";
            switch (num)
            {
                case 1:
                    ErrorText = "全ての項目へ入力が必要です。";
                    break;
                case 2:
                    ErrorText = "データがありません。";
                    break;
                case 3:
                    ErrorText = "変更するものが選択されていません。";
                    break;
                case 4:
                    ErrorText = "画像がありません。";
                    break;
                case 5:
                    ErrorText = "削除する行を選択してください。";
                    break;
                case 6:
                    ErrorText = "同じ名前のデータが既に存在します。";
                    break;
                case 7:
                    ErrorText = "変更する行が選択されていません。";
                    break;
                case 8:
                    ErrorText = "画像を選択してください。";
                    break;
            }
            MessageBox.Show(ErrorText,
            "エラー",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }

        private void btOpenImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdOpenImage.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                pbCardImage.Image = Image.FromFile(ofdOpenImage.FileName);
                pbCardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btClearImage_Click(object sender, EventArgs e)
        {
            pbCardImage.Image = null;
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            if (dgvCardDate.Rows.Count == 0)
            {
                ErrorMessage(2);
            }else{
                if (dgvCardDate.SelectedRows.Count <= 0)
                {
                    ErrorMessage(7);
                } else
                {
                    Modify();
                    UpdateAll();
                }
            }
        }

        private void Modify()
        {
            RadioSet();
            switch (color)
            {
                case "赤":
                    dgvCardDate.CurrentRow.Cells[4].Value = CardColor.赤;
                    break;
                case "青":
                    dgvCardDate.CurrentRow.Cells[4].Value = CardColor.青;
                    break;
                case "緑":
                    dgvCardDate.CurrentRow.Cells[4].Value = CardColor.緑;
                    break;
                case "白":
                    dgvCardDate.CurrentRow.Cells[4].Value = CardColor.白;
                    break;
                case "黒":
                    dgvCardDate.CurrentRow.Cells[4].Value = CardColor.黒;
                    break;
                case "無":
                    dgvCardDate.CurrentRow.Cells[4].Value = CardColor.無;
                    break;
            }
            switch (cost)
            {
                case "1":
                    dgvCardDate.CurrentRow.Cells[9].Value = "1";
                    break;
                case "2":
                    dgvCardDate.CurrentRow.Cells[9].Value = "2";
                    break;
                case "3":
                    dgvCardDate.CurrentRow.Cells[9].Value = "3";
                    break;
                case "4":
                    dgvCardDate.CurrentRow.Cells[9].Value = "4";
                    break;
                case "5":
                    dgvCardDate.CurrentRow.Cells[9].Value = "5";
                    break;
                case "6":
                    dgvCardDate.CurrentRow.Cells[9].Value = "6";
                    break;
                case "7":
                    dgvCardDate.CurrentRow.Cells[9].Value = "7";
                    break;
                case "8":
                    dgvCardDate.CurrentRow.Cells[9].Value = "8";
                    break;
                case "9":
                    dgvCardDate.CurrentRow.Cells[9].Value = "9";
                    break;
                case "10+":
                    dgvCardDate.CurrentRow.Cells[9].Value = "10+";
                    break;
            }
            dgvCardDate.CurrentRow.Cells[1].Value = dtpData.Value.ToString();
            dgvCardDate.CurrentRow.Cells[3].Value = cbCardType.Text;
            dgvCardDate.CurrentRow.Cells[5].Value = tbCardName.Text;
            dgvCardDate.CurrentRow.Cells[6].Value = tbCardEffect.Text;

            if (pbCardImage.Image != null)
            {
                dgvCardDate.CurrentRow.Cells[7].Value = ImageToByteArray(pbCardImage.Image);
            } else {
                dgvCardDate.CurrentRow.Cells[7].Value = null;
            }
            dgvCardDate.CurrentRow.Cells[8].Value = cbExpansion.Text;
            dgvCardDate.CurrentRow.Cells[10].Value = cbRare.Text;
            dgvCardDate.CurrentRow.Cells[11].Value = int.Parse(tbHave.Text);
            this.dgvCardDate.Refresh();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCardDate.SelectedRows.Count <= 0)
                {
                    ErrorMessage(5);
                } else{
                    cards.RemoveAt(SelectRow);
                    this.dgvCardDate.Refresh();
                    TextErase();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                ErrorMessage(2);
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbCardType.Text = null;
            tbCardName.Text = null;
            rbRed.Checked = false;
            rbBlue.Checked = false;
            rbGreen.Checked = false;
            rbWhite.Checked = false;
            rbBlack.Checked = false;
            rbNoColor.Checked = false;
            rbCost1.Checked = false;
            rbCost2.Checked = false;
            rbCost3.Checked = false;
            rbCost4.Checked = false;
            rbCost5.Checked = false;
            rbCost6.Checked = false;
            rbCost7.Checked = false;
            rbCost8.Checked = false;
            rbCost9.Checked = false;
            rbCost10over.Checked = false;
            tbCardEffect.Text = null;
            pbCardImage.Image = null;
            cbRare.Text = null;
            tbHave.Text = "0";
            cbExpansion.Text = null;
            dgvCardDate.ClearSelection();
            //RadioReset();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = ofdOpenData.FileName;
            Text = Path.GetFileName(ofdOpenData.FileName) + " - メモ帳";
            保存SToolStripMenuItem.Enabled = true;
            
            //オープンファイルダイアログを表示
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化
                        cards = (BindingList<Card>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvCardDate.DataSource = cards;
                        dgvCardDate.ClearSelection();
                    } catch (SerializationException g)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + g.Message);
                        throw;
                    }
                }
            }
            pbCardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            dgvCardDate.Columns[0].AutoSizeMode =DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCardDate.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void 修正ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify();
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを生成
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, cards);
                    } catch (SerializationException w)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + w.Message);
                        throw;
                    }
                }
            }
        }

        private void 上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(FileName, textBox1.Text, Encoding.GetEncoding("Shift_JIS"));
        }

        private void pbCardImage_Click(object sender, EventArgs e)
        {
            if (pbCardImage.Image == null)
            {
                ErrorMessage(4);
            } else {
                bigPicture.Show();
                bigPicture.BigPic(pbCardImage.Image);
            }
        }

        private void tbHave_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void dgvCardDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCardDate.CurrentRow.Cells[7].Value == ""){
            } else {
                pbCardImage.Image = ByteArrayToImage((byte[])dgvCardDate.CurrentRow.Cells[7].Value); 
            }
            SelectRow = dgvCardDate.CurrentCell.RowIndex;
            RabelSet();
        }

        private void RabelSet()
        {
            color = dgvCardDate.CurrentRow.Cells[4].Value.ToString();
            switch (color)
            {
                case "赤":
                    rbRed.Checked = true;
                    break;
                case "青":
                    rbBlue.Checked = true;
                    break;
                case "緑":
                    rbGreen.Checked = true;
                    break;
                case "白":
                    rbWhite.Checked = true;
                    break;
                case "黒":
                    rbBlack.Checked = true;
                    break;
                case "無":
                    rbNoColor.Checked = true;
                    break;
            }
            cost = dgvCardDate.CurrentRow.Cells[9].Value.ToString();
            switch (cost)
            {
                case "1":
                    rbCost1.Checked = true;
                    break;
                case "2":
                    rbCost2.Checked = true;
                    break;
                case "3":
                    rbCost3.Checked = true;
                    break;
                case "4":
                    rbCost4.Checked = true;
                    break;
                case "5":
                    rbCost5.Checked = true;
                    break;
                case "6":
                    rbCost6.Checked = true;
                    break;
                case "7":
                    rbCost7.Checked = true;
                    break;
                case "8":
                    rbCost8.Checked = true;
                    break;
                case "9":
                    rbCost9.Checked = true;
                    break;
                case "10+":
                    rbCost10over.Checked = true;
                    break;
            }
        }

        private void cardReportSystemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardReportSystemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202007DataSet);

        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202007DataSet.CardReportSystem' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cardReportSystemTableAdapter.Fill(this.infosys202007DataSet.CardReportSystem);
            pbCardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            RabelSet();
        }

        private void データベースへ上書きToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void UpdateAll()
        {
            this.Validate();
            this.cardReportSystemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202007DataSet);
        }

        //Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        private void btSearchExe_Click(object sender, EventArgs e)
        {
            if (cbSearchDate.Checked == true)
            {
                this.cardReportSystemTableAdapter.FillByCardALL(this.infosys202007DataSet.CardReportSystem, dtpSearchCardCreatedDate.Text, tbSearchCardColor.Text ,tbSearchCardName.Text);
            } else {
                this.cardReportSystemTableAdapter.FillByCardNoDate(this.infosys202007DataSet.CardReportSystem, tbSearchCardColor.Text, tbSearchCardName.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchReset_Click(object sender, EventArgs e)
        {
            tbSearchCardName.Text = "";
            tbSearchCardColor.Text = "";
            cbSearchDate.Checked = false;
            this.cardReportSystemTableAdapter.FillByCardNoDate(this.infosys202007DataSet.CardReportSystem, tbSearchCardColor.Text, tbSearchCardName.Text);
        }
    }
}
