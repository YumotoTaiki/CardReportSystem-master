namespace CardReportSystem
{
    partial class Sort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbNoColor = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btDecided = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbNoColor);
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbWhite);
            this.gbColor.Controls.Add(this.rbGreen);
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Location = new System.Drawing.Point(57, 152);
            this.gbColor.Margin = new System.Windows.Forms.Padding(4);
            this.gbColor.Name = "gbColor";
            this.gbColor.Padding = new System.Windows.Forms.Padding(4);
            this.gbColor.Size = new System.Drawing.Size(341, 50);
            this.gbColor.TabIndex = 28;
            this.gbColor.TabStop = false;
            // 
            // rbNoColor
            // 
            this.rbNoColor.AutoSize = true;
            this.rbNoColor.Location = new System.Drawing.Point(287, 20);
            this.rbNoColor.Margin = new System.Windows.Forms.Padding(4);
            this.rbNoColor.Name = "rbNoColor";
            this.rbNoColor.Size = new System.Drawing.Size(43, 19);
            this.rbNoColor.TabIndex = 27;
            this.rbNoColor.Text = "無";
            this.rbNoColor.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(232, 20);
            this.rbBlack.Margin = new System.Windows.Forms.Padding(4);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(43, 19);
            this.rbBlack.TabIndex = 9;
            this.rbBlack.Text = "黒";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(13, 20);
            this.rbRed.Margin = new System.Windows.Forms.Padding(4);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(43, 19);
            this.rbRed.TabIndex = 5;
            this.rbRed.Text = "赤";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(177, 20);
            this.rbWhite.Margin = new System.Windows.Forms.Padding(4);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(43, 19);
            this.rbWhite.TabIndex = 8;
            this.rbWhite.Text = "白";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(123, 20);
            this.rbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(43, 19);
            this.rbGreen.TabIndex = 7;
            this.rbGreen.Text = "緑";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(68, 20);
            this.rbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(43, 19);
            this.rbBlue.TabIndex = 6;
            this.rbBlue.Text = "青";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "色：";
            // 
            // btDecided
            // 
            this.btDecided.Location = new System.Drawing.Point(421, 510);
            this.btDecided.Name = "btDecided";
            this.btDecided.Size = new System.Drawing.Size(134, 33);
            this.btDecided.TabIndex = 29;
            this.btDecided.Text = "決定";
            this.btDecided.UseVisualStyleBackColor = true;
            this.btDecided.Click += new System.EventHandler(this.btDecided_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(264, 510);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(134, 33);
            this.btReset.TabIndex = 30;
            this.btReset.Text = "条件リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 559);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btDecided);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.label3);
            this.Name = "Sort";
            this.Text = "Sort";
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbNoColor;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDecided;
        private System.Windows.Forms.Button btReset;
    }
}