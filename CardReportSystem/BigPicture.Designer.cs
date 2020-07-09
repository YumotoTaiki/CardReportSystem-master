namespace CardReportSystem
{
    partial class BigPicture
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
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.btEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCard
            // 
            this.pbCard.Location = new System.Drawing.Point(3, 12);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(399, 589);
            this.pbCard.TabIndex = 0;
            this.pbCard.TabStop = false;
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(6, 605);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(395, 36);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "閉じる";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // BigPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 642);
            this.ControlBox = false;
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.pbCard);
            this.Name = "BigPicture";
            this.Text = "BigPicture";
            this.Load += new System.EventHandler(this.BigPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.Button btEnd;
    }
}