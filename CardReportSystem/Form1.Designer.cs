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
            this.components = new System.ComponentModel.Container();
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
            this.cardReportSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202007DataSet = new CardReportSystem.infosys202007DataSet();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btClearImage = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbNoColor = new System.Windows.Forms.RadioButton();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.cbExpansion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbRare = new System.Windows.Forms.ComboBox();
            this.tbHave = new System.Windows.Forms.TextBox();
            this.gbCost = new System.Windows.Forms.GroupBox();
            this.rbCost10over = new System.Windows.Forms.RadioButton();
            this.rbCost6 = new System.Windows.Forms.RadioButton();
            this.rbCost5 = new System.Windows.Forms.RadioButton();
            this.rbCost9 = new System.Windows.Forms.RadioButton();
            this.rbCost1 = new System.Windows.Forms.RadioButton();
            this.rbCost8 = new System.Windows.Forms.RadioButton();
            this.rbCost4 = new System.Windows.Forms.RadioButton();
            this.rbCost7 = new System.Windows.Forms.RadioButton();
            this.rbCost3 = new System.Windows.Forms.RadioButton();
            this.rbCost2 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修正ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCardName = new System.Windows.Forms.TextBox();
            this.dgvCardDate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchCardName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSearchDate = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSearchCardColor = new System.Windows.Forms.TextBox();
            this.dtpSearchCardCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearchReset = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.cardReportSystemTableAdapter = new CardReportSystem.infosys202007DataSetTableAdapters.CardReportSystemTableAdapter();
            this.tableAdapterManager = new CardReportSystem.infosys202007DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.cardReportSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202007DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.gbColor.SuspendLayout();
            this.gbCost.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardDate)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(29, 224);
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
            this.tbCardEffect.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportSystemBindingSource, "Effect", true));
            this.tbCardEffect.Location = new System.Drawing.Point(72, 224);
            this.tbCardEffect.Multiline = true;
            this.tbCardEffect.Name = "tbCardEffect";
            this.tbCardEffect.Size = new System.Drawing.Size(782, 180);
            this.tbCardEffect.TabIndex = 10;
            // 
            // cardReportSystemBindingSource
            // 
            this.cardReportSystemBindingSource.DataMember = "CardReportSystem";
            this.cardReportSystemBindingSource.DataSource = this.infosys202007DataSet;
            // 
            // infosys202007DataSet
            // 
            this.infosys202007DataSet.DataSetName = "infosys202007DataSet";
            this.infosys202007DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbCardType
            // 
            this.cbCardType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportSystemBindingSource, "Type", true));
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
            // pbCardImage
            // 
            this.pbCardImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cardReportSystemBindingSource, "Picture", true));
            this.pbCardImage.Location = new System.Drawing.Point(945, 68);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(215, 312);
            this.pbCardImage.TabIndex = 16;
            this.pbCardImage.TabStop = false;
            this.pbCardImage.Click += new System.EventHandler(this.pbCardImage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(895, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "画像：";
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(1171, 66);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(83, 23);
            this.btOpenImage.TabIndex = 18;
            this.btOpenImage.Text = "開く...";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btClearImage
            // 
            this.btClearImage.Location = new System.Drawing.Point(1171, 109);
            this.btClearImage.Name = "btClearImage";
            this.btClearImage.Size = new System.Drawing.Size(83, 23);
            this.btClearImage.TabIndex = 19;
            this.btClearImage.Text = "画像クリア";
            this.btClearImage.UseVisualStyleBackColor = true;
            this.btClearImage.Click += new System.EventHandler(this.btClearImage_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(906, 399);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 29);
            this.btAdd.TabIndex = 20;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(1037, 399);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(83, 29);
            this.btModify.TabIndex = 21;
            this.btModify.Text = "修正";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1166, 399);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 29);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
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
            // cbExpansion
            // 
            this.cbExpansion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportSystemBindingSource, "Expansion", true));
            this.cbExpansion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExpansion.FormattingEnabled = true;
            this.cbExpansion.Items.AddRange(new object[] {
            "Jumpstart",
            "基本セット2021",
            "統率者（2020年版）",
            "イコリア：巨獣の棲処",
            "Mystery Booster（WPN version）",
            "Unsanctioned",
            "テーロス還魂記",
            "エルドレインの王権",
            "統率者（2019年版）",
            "基本セット2020",
            "Signature Spellbook: Gideon",
            "モダンホライゾン",
            "灯争大戦",
            "ラヴニカの献身",
            "アルティメットマスターズ",
            "ラヴニカのギルド",
            "統率者（2018年版）",
            "基本セット2019",
            "Global Series: Jiang Yanggu and Mu Yanling",
            "Signature Spellbook: Jace",
            "バトルボンド",
            "ドミナリア",
            "デュエルデッキ：エルフ vs 発明者",
            "マスターズ25th",
            "イクサランの相克",
            "Unstable",
            "Explorers of Ixalan",
            "From the Vault: Transform",
            "アイコニックマスターズ",
            "デュエルデッキ：マーフォーク vs ゴブリン",
            "イクサラン",
            "統率者（2017年版）",
            "破滅の刻",
            "Archenemy:Nicol Bolas",
            "Commander Anthology",
            "アモンケット",
            "デュエルデッキ：精神 vs 物理",
            "モダンマスターズ 2017年版",
            "霊気紛争",
            "統率者（2016年版）",
            "カラデシュ",
            "デュエルデッキ：ニッサ vs オブ・ニクシリス",
            "コンスピラシー：王位争奪",
            "From the Vault: Lore",
            "異界月",
            "エターナルマスターズ",
            "イニストラードを覆う影",
            "デュエルデッキ：正しき者 vs 堕ちし者",
            "ゲートウォッチの誓い",
            "統率者（2015年版）",
            "戦乱のゼンディカー",
            "デュエルデッキ：ゼンディカー vs エルドラージ",
            "From the Vault: Angels",
            "マジック・オリジン",
            "モダンマスターズ 2015年版",
            "タルキール龍紀伝",
            "デュエルデッキ：エルズペス vs キオーラ",
            "運命再編",
            "統率者（2014年版）",
            "タルキール覇王譚",
            "デュエルデッキ：迅速 vs 狡知",
            "From The Vault: Annihilation",
            "基本セット2015",
            "コンスピラシー",
            "Modern Event Deck",
            "デュエルデッキ：ジェイス vs ヴラスカ",
            "ニクスへの旅",
            "神々の軍勢",
            "統率者（2013年版）",
            "テーロス",
            "デュエルデッキ：英雄vs怪物",
            "From the Vault: Twenty",
            "基本セット2014",
            "Modern Masters",
            "ドラゴンの迷路",
            "デュエルデッキ：ソリンvsティボルト",
            "ギルド門侵犯",
            "COMMANDER\'S ARSENAL",
            "ラヴニカへの回帰",
            "デュエルデッキ：イゼット vs. ゴルガリ",
            "From the Vault: Realms",
            "基本セット2013",
            "プレインチェイス（2012年版）",
            "アヴァシンの帰還",
            "デュエルデッキ：ヴェンセール vs. コス",
            "闇の隆盛",
            "Premium Deck Series: Graveborn",
            "イニストラード",
            "Duel Decks: Ajani vs. Nicol Bolas",
            "From the Vault: Legends",
            "基本セット2012",
            "統率者（2011年版）",
            "新たなるファイレクシア",
            "Duel Decks: Knights vs. Dragons",
            "ミラディン包囲戦",
            "Premium Deck Series: Fire & Lightning",
            "ミラディンの傷跡",
            "Duel Decks: Elspeth vs Tezzeret",
            "From the Vault: Relics",
            "基本セット2011",
            "Archenemy",
            "エルドラージ覚醒",
            "デュエルデッキ：ファイレクシアvsドミナリア連合",
            "ワールドウェイク",
            "Premium Deck Series: SLIVERS",
            "DUEL DECKS: GARRUK VS. LILIANA",
            "ゼンディカー",
            "Planechase",
            "From the Vault: Exiled",
            "基本セット2010",
            "アラーラ再誕",
            "デュエルデッキ：ジェイス vs. チャンドラ",
            "アラーラの断片",
            "DUEL DECKS: DIVINE VS. DEMONIC",
            "コンフラックス",
            "From the Vault:Dragons",
            "イーブンタイド",
            "シャドウムーア",
            "モーニングタイド",
            "DUEL DECKS: Elves VS. Goblins",
            "ローウィン",
            "基本セット第１０版",
            "未来予知",
            "次元の混乱",
            "時のらせん",
            "コールドスナップ",
            "ディセンション",
            "ギルドパクト",
            "ラヴニカ：ギルドの都",
            "基本セット第９版",
            "神河救済",
            "神河謀叛",
            "Unhinged",
            "神河物語",
            "フィフス・ドーン",
            "ダークスティール",
            "ミラディン",
            "第８版基本セット",
            "スカージ",
            "レギオン",
            "オンスロート",
            "ジャッジメント",
            "トーメント",
            "オデッセイ",
            "アポカリプス",
            "基本セット第７版",
            "プレーンシフト",
            "インベイジョン",
            "プロフェシー",
            "ネメシス",
            "メルカディアン・マスクス",
            "基本セット第６版「クラシック」",
            "ウルザズ・デスティニー",
            "ポータル三国志",
            "ウルザズ・レガシー",
            "ウルザズ・サーガ",
            "Unglued",
            "ポータル・セカンド",
            "エクソダス",
            "ストロングホールド",
            "テンペスト",
            "ポータル",
            "ウェザーライト",
            "基本セット第５版",
            "ビジョンズ",
            "ミラージュ",
            "アライアンス",
            "ホームランド",
            "アイスエイジ",
            "クロニクル",
            "基本セット第４版",
            "フォールン・エンパイア",
            "ザ・ダーク",
            "レジェンド",
            "リバイズド",
            "アンティキティー",
            "アラビアンナイト",
            "アルファ版・ベータ版・アンリミテッド"});
            this.cbExpansion.Location = new System.Drawing.Point(541, 34);
            this.cbExpansion.Name = "cbExpansion";
            this.cbExpansion.Size = new System.Drawing.Size(223, 20);
            this.cbExpansion.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "エキスパンション：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "コスト：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "レア度：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "所持枚数：";
            // 
            // cbRare
            // 
            this.cbRare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportSystemBindingSource, "Rarity", true));
            this.cbRare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRare.FormattingEnabled = true;
            this.cbRare.Items.AddRange(new object[] {
            "コモン",
            "アンコモン",
            "レア",
            "神話レア"});
            this.cbRare.Location = new System.Drawing.Point(541, 159);
            this.cbRare.Name = "cbRare";
            this.cbRare.Size = new System.Drawing.Size(136, 20);
            this.cbRare.TabIndex = 34;
            // 
            // tbHave
            // 
            this.tbHave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportSystemBindingSource, "Have", true));
            this.tbHave.Location = new System.Drawing.Point(541, 187);
            this.tbHave.Name = "tbHave";
            this.tbHave.Size = new System.Drawing.Size(100, 19);
            this.tbHave.TabIndex = 36;
            this.tbHave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHave_KeyPress);
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
            this.gbCost.Location = new System.Drawing.Point(541, 71);
            this.gbCost.Name = "gbCost";
            this.gbCost.Size = new System.Drawing.Size(223, 82);
            this.gbCost.TabIndex = 37;
            this.gbCost.TabStop = false;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1485, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.接続ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.上書き保存ToolStripMenuItem,
            this.保存SToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // 新規作成NToolStripMenuItem
            // 
            this.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem";
            this.新規作成NToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.新規作成NToolStripMenuItem.Text = "新規作成(&N)";
            this.新規作成NToolStripMenuItem.Click += new System.EventHandler(this.新規作成NToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.開くToolStripMenuItem.Text = "開く(&O)";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 接続ToolStripMenuItem
            // 
            this.接続ToolStripMenuItem.Name = "接続ToolStripMenuItem";
            this.接続ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.接続ToolStripMenuItem.Text = "接続";
            this.接続ToolStripMenuItem.Click += new System.EventHandler(this.接続ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.更新ToolStripMenuItem.Text = "データベースへ上書き";
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Enabled = false;
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.上書き保存ToolStripMenuItem.Text = "上書き保存(&L)";
            this.上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.上書き保存ToolStripMenuItem_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.保存SToolStripMenuItem.Text = "名前を付けて保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修正ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 修正ToolStripMenuItem
            // 
            this.修正ToolStripMenuItem.Enabled = false;
            this.修正ToolStripMenuItem.Name = "修正ToolStripMenuItem";
            this.修正ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.修正ToolStripMenuItem.Text = "修正";
            this.修正ToolStripMenuItem.Click += new System.EventHandler(this.修正ToolStripMenuItem_Click);
            // 
            // tbCardName
            // 
            this.tbCardName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportSystemBindingSource, "Name", true));
            this.tbCardName.Location = new System.Drawing.Point(72, 187);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.Size = new System.Drawing.Size(200, 19);
            this.tbCardName.TabIndex = 39;
            // 
            // dgvCardDate
            // 
            this.dgvCardDate.AutoGenerateColumns = false;
            this.dgvCardDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvCardDate.DataSource = this.cardReportSystemBindingSource;
            this.dgvCardDate.Location = new System.Drawing.Point(12, 450);
            this.dgvCardDate.MultiSelect = false;
            this.dgvCardDate.Name = "dgvCardDate";
            this.dgvCardDate.ReadOnly = true;
            this.dgvCardDate.RowTemplate.Height = 21;
            this.dgvCardDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCardDate.Size = new System.Drawing.Size(1148, 270);
            this.dgvCardDate.TabIndex = 39;
            this.dgvCardDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCardDate_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Auther";
            this.dataGridViewTextBoxColumn3.HeaderText = "Auther";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Effect";
            this.dataGridViewTextBoxColumn7.HeaderText = "Effect";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Expansion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Expansion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Rarity";
            this.dataGridViewTextBoxColumn10.HeaderText = "Rarity";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Have";
            this.dataGridViewTextBoxColumn11.HeaderText = "Have";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // tbSearchCardName
            // 
            this.tbSearchCardName.Location = new System.Drawing.Point(6, 49);
            this.tbSearchCardName.Name = "tbSearchCardName";
            this.tbSearchCardName.Size = new System.Drawing.Size(172, 19);
            this.tbSearchCardName.TabIndex = 40;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 12);
            this.label.TabIndex = 41;
            this.label.Text = "名前";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cbSearchDate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbSearchCardColor);
            this.groupBox1.Controls.Add(this.dtpSearchCardCreatedDate);
            this.groupBox1.Controls.Add(this.tbSearchReset);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btSearchExe);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.tbSearchCardName);
            this.groupBox1.Location = new System.Drawing.Point(1273, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 236);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // cbSearchDate
            // 
            this.cbSearchDate.AutoSize = true;
            this.cbSearchDate.Location = new System.Drawing.Point(41, 137);
            this.cbSearchDate.Name = "cbSearchDate";
            this.cbSearchDate.Size = new System.Drawing.Size(138, 16);
            this.cbSearchDate.TabIndex = 46;
            this.cbSearchDate.Text = "日付を検索条件に追加";
            this.cbSearchDate.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 44;
            this.label13.Text = "色";
            // 
            // tbSearchCardColor
            // 
            this.tbSearchCardColor.Location = new System.Drawing.Point(6, 106);
            this.tbSearchCardColor.Name = "tbSearchCardColor";
            this.tbSearchCardColor.Size = new System.Drawing.Size(172, 19);
            this.tbSearchCardColor.TabIndex = 43;
            // 
            // dtpSearchCardCreatedDate
            // 
            this.dtpSearchCardCreatedDate.Checked = false;
            this.dtpSearchCardCreatedDate.Location = new System.Drawing.Point(6, 163);
            this.dtpSearchCardCreatedDate.Name = "dtpSearchCardCreatedDate";
            this.dtpSearchCardCreatedDate.Size = new System.Drawing.Size(172, 19);
            this.dtpSearchCardCreatedDate.TabIndex = 45;
            // 
            // tbSearchReset
            // 
            this.tbSearchReset.Location = new System.Drawing.Point(95, 198);
            this.tbSearchReset.Name = "tbSearchReset";
            this.tbSearchReset.Size = new System.Drawing.Size(83, 31);
            this.tbSearchReset.TabIndex = 43;
            this.tbSearchReset.Text = "検索リセット";
            this.tbSearchReset.UseVisualStyleBackColor = true;
            this.tbSearchReset.Click += new System.EventHandler(this.SearchReset_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 44;
            this.label12.Text = "日付";
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(8, 198);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(72, 31);
            this.btSearchExe.TabIndex = 42;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // cardReportSystemTableAdapter
            // 
            this.cardReportSystemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardReportSystemTableAdapter = this.cardReportSystemTableAdapter;
            this.tableAdapterManager.UpdateOrder = CardReportSystem.infosys202007DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 740);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCardDate);
            this.Controls.Add(this.tbCardName);
            this.Controls.Add(this.gbCost);
            this.Controls.Add(this.tbHave);
            this.Controls.Add(this.cbRare);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbExpansion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClearImage);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.pbCardImage);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.cardReportSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202007DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.gbCost.ResumeLayout(false);
            this.gbCost.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbCardImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btClearImage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.RadioButton rbNoColor;
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
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成NToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修正ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private System.Windows.Forms.TextBox tbCardName;
        private infosys202007DataSet infosys202007DataSet;
        private System.Windows.Forms.BindingSource cardReportSystemBindingSource;
        private infosys202007DataSetTableAdapters.CardReportSystemTableAdapter cardReportSystemTableAdapter;
        private infosys202007DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCardDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripMenuItem 接続ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearchCardName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpSearchCardCreatedDate;
        private System.Windows.Forms.Button tbSearchReset;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSearchCardColor;
        private System.Windows.Forms.CheckBox cbSearchDate;
    }
}

