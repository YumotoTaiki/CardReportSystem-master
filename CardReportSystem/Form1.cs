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

        public Form1()
        {
            InitializeComponent();
            dgvCardDate.DataSource = cards;
            dgvCardDate.AllowUserToAddRows = false;
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

                AddData(color, cost);
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
            card.picture = pbCardImage.Image;
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
            string ErrorText="";
            switch (num)
            {
                case 1:
                    ErrorText = "全ての項目へ入力が必要です。";
                    break;
                case 2:
                    ErrorText = "選択した行にはデータがありません。";
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
            if (dgvCardDate.SelectedRows.Count <= 0)
            {
                ErrorMessage(7);
            } else {
                Modify();
            }
        }

        private void Modify()
        {
            try
            {
                RadioSet();
                switch (color)
                {
                    case "赤":
                        cards[SelectRow].color = CardColor.赤;
                        break;
                    case "青":
                        cards[SelectRow].color = CardColor.青;
                        break;
                    case "緑":
                        cards[SelectRow].color = CardColor.緑;
                        break;
                    case "白":
                        cards[SelectRow].color = CardColor.白;
                        break;
                    case "黒":
                        cards[SelectRow].color = CardColor.黒;
                        break;
                    case "無":
                        cards[SelectRow].color = CardColor.無;
                        break;
                }
                switch (cost)
                {
                    case "1":
                        cards[SelectRow].Cost = "1";
                        break;
                    case "2":
                        cards[SelectRow].Cost = "2";
                        break;
                    case "3":
                        cards[SelectRow].Cost = "3";
                        break;
                    case "4":
                        cards[SelectRow].Cost = "4";
                        break;
                    case "5":
                        cards[SelectRow].Cost = "5";
                        break;
                    case "6":
                        cards[SelectRow].Cost = "6";
                        break;
                    case "7":
                        cards[SelectRow].Cost = "7";
                        break;
                    case "8":
                        cards[SelectRow].Cost = "8";
                        break;
                    case "9":
                        cards[SelectRow].Cost = "9";
                        break;
                    case "10+":
                        cards[SelectRow].Cost = "10+";
                        break;
                }
                cards[SelectRow].Expansion = cbExpansion.Text;
                cards[SelectRow].Have = int.Parse(tbHave.Text);
                cards[SelectRow].Rarity = cbRare.Text;
                cards[SelectRow].type = cbCardType.Text;
                cards[SelectRow].name = tbCardName.Text;
                cards[SelectRow].Effect = tbCardEffect.Text;
                cards[SelectRow].picture = pbCardImage.Image;
                this.dgvCardDate.Refresh();
            } catch (Exception)
            {
                ErrorMessage(3);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCardDate.SelectedRows.Count <= 0)
                {
                    ErrorMessage(5);
                } else
                {
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
            try
            {
                SelectRow = dgvCardDate.CurrentCell.RowIndex;

                dtpData.Text = dgvCardDate.CurrentRow.Cells[0].Value.ToString();
                cbCardType.Text = dgvCardDate.CurrentRow.Cells[1].Value.ToString();
                color = dgvCardDate.CurrentRow.Cells[2].Value.ToString();
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
                cost = dgvCardDate.CurrentRow.Cells[7].Value.ToString();
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
                tbCardName.Text = dgvCardDate.CurrentRow.Cells[3].Value.ToString();
                tbCardEffect.Text = dgvCardDate.CurrentRow.Cells[4].Value.ToString();
                pbCardImage.Image = cards[SelectRow].picture;
                cbRare.Text = dgvCardDate.CurrentRow.Cells[8].Value.ToString();
                cbExpansion.Text = dgvCardDate.CurrentRow.Cells[6].Value.ToString();
                tbHave.Text = dgvCardDate.CurrentRow.Cells[9].Value.ToString();
            } catch (Exception)
            {
                ErrorMessage(2);
            }
        }
    }
}
