namespace Gulomova
{
    partial class FormParent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNames = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // labelTitle
            //
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Modifiers = System.CodeDom.MemberAttributes.Family;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Text = "Форма";
            //
            // pictureBox1
            //
            this.pictureBox1.Location = new System.Drawing.Point(25, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabStop = false;
            //
            // labelNames
            //
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNames.Location = new System.Drawing.Point(200, 90);
            this.labelNames.Name = "labelNames";
            this.labelNames.Text = "labelNames";
            //
            // labelRole
            //
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRole.Location = new System.Drawing.Point(200, 130);
            this.labelRole.Name = "labelRole";
            this.labelRole.Text = "labelRole";
            //
            // buttonBack
            //
            this.buttonBack.Location = new System.Drawing.Point(25, 235);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 30);
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            //
            // FormParent
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 290);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParent";
            this.Load += new System.EventHandler(this.FormParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Label labelRole;
        protected System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBack;
    }
}
