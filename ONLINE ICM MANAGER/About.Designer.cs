namespace ONLINE_ICM_MANAGER
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AboutSectionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AboutSectionTextBox
            // 
            this.AboutSectionTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AboutSectionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.AboutSectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutSectionTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSectionTextBox.Location = new System.Drawing.Point(12, 42);
            this.AboutSectionTextBox.Name = "AboutSectionTextBox";
            this.AboutSectionTextBox.ReadOnly = true;
            this.AboutSectionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.AboutSectionTextBox.Size = new System.Drawing.Size(1855, 970);
            this.AboutSectionTextBox.TabIndex = 0;
            this.AboutSectionTextBox.Text = resources.GetString("AboutSectionTextBox.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1879, 1050);
            this.Controls.Add(this.AboutSectionTextBox);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AboutSectionTextBox;
    }
}