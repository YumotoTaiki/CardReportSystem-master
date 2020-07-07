namespace CardReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.tbCardEffect = new System.Windows.Forms.TextBox();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.cbCardName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCardDate = new System.Windows.Forms.DataGridView();
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btClearImage = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbNoColor = new System.Windows.Forms.RadioButton();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.btNew = new System.Windows.Forms.Button();
            this.cbExpansion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbRare = new System.Windows.Forms.ComboBox();
            this.tbHave = new System.Windows.Forms.TextBox();
            this.gbCost = new System.Windows.Forms.GroupBox();
            this.rbCost5 = new System.Windows.Forms.RadioButton();
            this.rbCost1 = new System.Windows.Forms.RadioButton();
            this.rbCost4 = new System.Windows.Forms.RadioButton();
            this.rbCost3 = new System.Windows.Forms.RadioButton();
            this.rbCost2 = new System.Windows.Forms.RadioButton();
            this.rbCost10over = new System.Windows.Forms.RadioButton();
            this.rbCost6 = new System.Windows.Forms.RadioButton();
            this.rbCost9 = new System.Windows.Forms.RadioButton();
            this.rbCost8 = new System.Windows.Forms.RadioButton();
            this.rbCost7 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.gbColor.SuspendLayout();
            this.gbCost.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(72, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 19);
            this.dtpData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "タイプ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "効果：";
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(10, 16);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(35, 16);
            this.rbRed.TabIndex = 5;
            this.rbRed.Text = "赤";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(51, 16);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(35, 16);
            this.rbBlue.TabIndex = 6;
            this.rbBlue.Text = "青";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(92, 16);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(35, 16);
            this.rbGreen.TabIndex = 7;
            this.rbGreen.Text = "緑";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(133, 16);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(35, 16);
            this.rbWhite.TabIndex = 8;
            this.rbWhite.Text = "白";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(174, 16);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(35, 16);
            this.rbBlack.TabIndex = 9;
            this.rbBlack.Text = "黒";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // tbCardEffect
            // 
            this.tbCardEffect.Location = new System.Drawing.Point(72, 225);
            this.tbCardEffect.Multiline = true;
            this.tbCardEffect.Name = "tbCardEffect";
            this.tbCardEffect.Size = new System.Drawing.Size(581, 156);
            this.tbCardEffect.TabIndex = 10;
            // 
            // cbCardType
            // 
            this.cbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Items.AddRange(new object[] {
            "クリーチャー",
            "インスタント",
            "ソーサリー",
            "エンチャント",
            "アーティファクト",
            "プレインズウォーカー"});
            this.cbCardType.Location = new System.Drawing.Point(72, 82);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(200, 20);
            this.cbCardType.TabIndex = 11;
            // 
            // cbCardName
            // 
            this.cbCardName.FormattingEnabled = true;
            this.cbCardName.Location = new System.Drawing.Point(72, 184);
            this.cbCardName.Name = "cbCardName";
            this.cbCardName.Size = new System.Drawing.Size(200, 20);
            this.cbCardName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "カード名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "記事一覧：";
            // 
            // dgvCardDate
            // 
            this.dgvCardDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardDate.Location = new System.Drawing.Point(72, 402);
            this.dgvCardDate.Name = "dgvCardDate";
            this.dgvCardDate.ReadOnly = true;
            this.dgvCardDate.RowTemplate.Height = 21;
            this.dgvCardDate.Size = new System.Drawing.Size(941, 214);
            this.dgvCardDate.TabIndex = 15;
            this.dgvCardDate.Click += new System.EventHandler(this.dgvCardDate_Click);
            // 
            // pbCardImage
            // 
            this.pbCardImage.Location = new System.Drawing.Point(709, 36);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(215, 312);
            this.pbCardImage.TabIndex = 16;
            this.pbCardImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "画像：";
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(930, 31);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(83, 23);
            this.btOpenImage.TabIndex = 18;
            this.btOpenImage.Text = "開く...";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btClearImage
            // 
            this.btClearImage.Location = new System.Drawing.Point(930, 74);
            this.btClearImage.Name = "btClearImage";
            this.btClearImage.Size = new System.Drawing.Size(83, 23);
            this.btClearImage.TabIndex = 19;
            this.btClearImage.Text = "画像クリア";
            this.btClearImage.UseVisualStyleBackColor = true;
            this.btClearImage.Click += new System.EventHandler(this.btClearImage_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(750, 352);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 29);
            this.btAdd.TabIndex = 20;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(841, 352);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(83, 29);
            this.btModify.TabIndex = 21;
            this.btModify.Text = "修正";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(930, 352);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 29);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRoad
            // 
            this.btRoad.Location = new System.Drawing.Point(10, 456);
            this.btRoad.Name = "btRoad";
            this.btRoad.Size = new System.Drawing.Size(56, 39);
            this.btRoad.TabIndex = 23;
            this.btRoad.Text = "開く";
            this.btRoad.UseVisualStyleBackColor = true;
            this.btRoad.Click += new System.EventHandler(this.btRoad_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(10, 526);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(56, 39);
            this.btSave.TabIndex = 24;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(930, 622);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(83, 21);
            this.btEnd.TabIndex = 25;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbNoColor);
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbWhite);
            this.gbColor.Controls.Add(this.rbGreen);
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Location = new System.Drawing.Point(72, 119);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(256, 40);
            this.gbColor.TabIndex = 26;
            this.gbColor.TabStop = false;
            // 
            // rbNoColor
            // 
            this.rbNoColor.AutoSize = true;
            this.rbNoColor.Location = new System.Drawing.Point(215, 16);
            this.rbNoColor.Name = "rbNoColor";
            this.rbNoColor.Size = new System.Drawing.Size(35, 16);
            this.rbNoColor.TabIndex = 27;
            this.rbNoColor.Text = "無";
            this.rbNoColor.UseVisualStyleBackColor = true;
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(661, 352);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(83, 29);
            this.btNew.TabIndex = 27;
            this.btNew.Text = "新規";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // cbExpansion
            // 
            this.cbExpansion.FormattingEnabled = true;
            this.cbExpansion.Items.AddRange(new object[] {
            "アモンケット",
            "基本セット2020",
            "イニストラードを覆う影",
            "イコリア"});
            this.cbExpansion.Location = new System.Drawing.Point(430, 31);
            this.cbExpansion.Name = "cbExpansion";
            this.cbExpansion.Size = new System.Drawing.Size(200, 20);
            this.cbExpansion.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "エキスパンション：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "コスト：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "レア度：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "所持枚数：";
            // 
            // cbRare
            // 
            this.cbRare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRare.FormattingEnabled = true;
            this.cbRare.Items.AddRange(new object[] {
            "コモン",
            "アンコモン",
            "レア",
            "神話レア"});
            this.cbRare.Location = new System.Drawing.Point(430, 156);
            this.cbRare.Name = "cbRare";
            this.cbRare.Size = new System.Drawing.Size(136, 20);
            this.cbRare.TabIndex = 34;
            // 
            // tbHave
            // 
            this.tbHave.Location = new System.Drawing.Point(430, 184);
            this.tbHave.Name = "tbHave";
            this.tbHave.Size = new System.Drawing.Size(100, 19);
            this.tbHave.TabIndex = 36;
            // 
            // gbCost
            // 
            this.gbCost.Controls.Add(this.rbCost10over);
            this.gbCost.Controls.Add(this.rbCost6);
            this.gbCost.Controls.Add(this.rbCost5);
            this.gbCost.Controls.Add(this.rbCost9);
            this.gbCost.Controls.Add(this.rbCost1);
            this.gbCost.Controls.Add(this.rbCost8);
            this.gbCost.Controls.Add(this.rbCost4);
            this.gbCost.Controls.Add(this.rbCost7);
            this.gbCost.Controls.Add(this.rbCost3);
            this.gbCost.Controls.Add(this.rbCost2);
            this.gbCost.Location = new System.Drawing.Point(430, 68);
            this.gbCost.Name = "gbCost";
            this.gbCost.Size = new System.Drawing.Size(223, 82);
            this.gbCost.TabIndex = 37;
            this.gbCost.TabStop = false;
            // 
            // rbCost5
            // 
            this.rbCost5.AutoSize = true;
            this.rbCost5.Location = new System.Drawing.Point(174, 16);
            this.rbCost5.Name = "rbCost5";
            this.rbCost5.Size = new System.Drawing.Size(29, 16);
            this.rbCost5.TabIndex = 9;
            this.rbCost5.Text = "5";
            this.rbCost5.UseVisualStyleBackColor = true;
            // 
            // rbCost1
            // 
            this.rbCost1.AutoSize = true;
            this.rbCost1.Location = new System.Drawing.Point(10, 16);
            this.rbCost1.Name = "rbCost1";
            this.rbCost1.Size = new System.Drawing.Size(29, 16);
            this.rbCost1.TabIndex = 5;
            this.rbCost1.Text = "1";
            this.rbCost1.UseVisualStyleBackColor = true;
            // 
            // rbCost4
            // 
            this.rbCost4.AutoSize = true;
            this.rbCost4.Location = new System.Drawing.Point(133, 16);
            this.rbCost4.Name = "rbCost4";
            this.rbCost4.Size = new System.Drawing.Size(29, 16);
            this.rbCost4.TabIndex = 8;
            this.rbCost4.Text = "4";
            this.rbCost4.UseVisualStyleBackColor = true;
            // 
            // rbCost3
            // 
            this.rbCost3.AutoSize = true;
            this.rbCost3.Location = new System.Drawing.Point(92, 16);
            this.rbCost3.Name = "rbCost3";
            this.rbCost3.Size = new System.Drawing.Size(29, 16);
            this.rbCost3.TabIndex = 7;
            this.rbCost3.Text = "3";
            this.rbCost3.UseVisualStyleBackColor = true;
            // 
            // rbCost2
            // 
            this.rbCost2.AutoSize = true;
            this.rbCost2.Location = new System.Drawing.Point(51, 16);
            this.rbCost2.Name = "rbCost2";
            this.rbCost2.Size = new System.Drawing.Size(29, 16);
            this.rbCost2.TabIndex = 6;
            this.rbCost2.Text = "2";
            this.rbCost2.UseVisualStyleBackColor = true;
            // 
            // rbCost10over
            // 
            this.rbCost10over.AutoSize = true;
            this.rbCost10over.Location = new System.Drawing.Point(174, 51);
            this.rbCost10over.Name = "rbCost10over";
            this.rbCost10over.Size = new System.Drawing.Size(41, 16);
            this.rbCost10over.TabIndex = 42;
            this.rbCost10over.Text = "10+";
            this.rbCost10over.UseVisualStyleBackColor = true;
            // 
            // rbCost6
            // 
            this.rbCost6.AutoSize = true;
            this.rbCost6.Location = new System.Drawing.Point(10, 51);
            this.rbCost6.Name = "rbCost6";
            this.rbCost6.Size = new System.Drawing.Size(29, 16);
            this.rbCost6.TabIndex = 38;
            this.rbCost6.Text = "6";
            this.rbCost6.UseVisualStyleBackColor = true;
            // 
            // rbCost9
            // 
            this.rbCost9.AutoSize = true;
            this.rbCost9.Location = new System.Drawing.Point(133, 51);
            this.rbCost9.Name = "rbCost9";
            this.rbCost9.Size = new System.Drawing.Size(29, 16);
            this.rbCost9.TabIndex = 41;
            this.rbCost9.Text = "9";
            this.rbCost9.UseVisualStyleBackColor = true;
            // 
            // rbCost8
            // 
            this.rbCost8.AutoSize = true;
            this.rbCost8.Location = new System.Drawing.Point(92, 51);
            this.rbCost8.Name = "rbCost8";
            this.rbCost8.Size = new System.Drawing.Size(29, 16);
            this.rbCost8.TabIndex = 40;
            this.rbCost8.Text = "8";
            this.rbCost8.UseVisualStyleBackColor = true;
            // 
            // rbCost7
            // 
            this.rbCost7.AutoSize = true;
            this.rbCost7.Location = new System.Drawing.Point(51, 51);
            this.rbCost7.Name = "rbCost7";
            this.rbCost7.Size = new System.Drawing.Size(29, 16);
            this.rbCost7.TabIndex = 39;
            this.rbCost7.Text = "7";
            this.rbCost7.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 649);
            this.Controls.Add(this.gbCost);
            this.Controls.Add(this.tbHave);
            this.Controls.Add(this.cbRare);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbExpansion);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btRoad);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClearImage);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.pbCardImage);
            this.Controls.Add(this.dgvCardDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCardName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCardType);
            this.Controls.Add(this.tbCardEffect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "カード管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.gbCost.ResumeLayout(false);
            this.gbCost.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.TextBox tbCardEffect;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.ComboBox cbCardName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCardDate;
        private System.Windows.Forms.PictureBox pbCardImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btClearImage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.RadioButton rbNoColor;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.ComboBox cbExpansion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbRare;
        private System.Windows.Forms.TextBox tbHave;
        private System.Windows.Forms.GroupBox gbCost;
        private System.Windows.Forms.RadioButton rbCost10over;
        private System.Windows.Forms.RadioButton rbCost6;
        private System.Windows.Forms.RadioButton rbCost5;
        private System.Windows.Forms.RadioButton rbCost9;
        private System.Windows.Forms.RadioButton rbCost1;
        private System.Windows.Forms.RadioButton rbCost8;
        private System.Windows.Forms.RadioButton rbCost4;
        private System.Windows.Forms.RadioButton rbCost7;
        private System.Windows.Forms.RadioButton rbCost3;
        private System.Windows.Forms.RadioButton rbCost2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
    }
}

