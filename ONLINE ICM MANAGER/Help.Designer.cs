namespace ONLINE_ICM_MANAGER
{
    partial class Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.Software_Descriptionlabel = new System.Windows.Forms.Label();
            this.rTB1 = new System.Windows.Forms.RichTextBox();
            this.Key_Features_label = new System.Windows.Forms.Label();
            this.rTB2 = new System.Windows.Forms.RichTextBox();
            this.Usage_Instructions_label = new System.Windows.Forms.Label();
            this.rTB3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Software_Descriptionlabel
            // 
            this.Software_Descriptionlabel.AutoSize = true;
            this.Software_Descriptionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Software_Descriptionlabel.Location = new System.Drawing.Point(43, 30);
            this.Software_Descriptionlabel.Name = "Software_Descriptionlabel";
            this.Software_Descriptionlabel.Size = new System.Drawing.Size(182, 20);
            this.Software_Descriptionlabel.TabIndex = 0;
            this.Software_Descriptionlabel.Text = "Software Description:";
            // 
            // rTB1
            // 
            this.rTB1.BackColor = System.Drawing.SystemColors.Control;
            this.rTB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTB1.Location = new System.Drawing.Point(56, 62);
            this.rTB1.Name = "rTB1";
            this.rTB1.ReadOnly = true;
            this.rTB1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTB1.Size = new System.Drawing.Size(952, 46);
            this.rTB1.TabIndex = 1;
            this.rTB1.Text = resources.GetString("rTB1.Text");
            // 
            // Key_Features_label
            // 
            this.Key_Features_label.AutoSize = true;
            this.Key_Features_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key_Features_label.Location = new System.Drawing.Point(43, 111);
            this.Key_Features_label.Name = "Key_Features_label";
            this.Key_Features_label.Size = new System.Drawing.Size(120, 20);
            this.Key_Features_label.TabIndex = 2;
            this.Key_Features_label.Text = "Key Features:";
            // 
            // rTB2
            // 
            this.rTB2.BackColor = System.Drawing.SystemColors.Control;
            this.rTB2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTB2.Location = new System.Drawing.Point(56, 134);
            this.rTB2.Name = "rTB2";
            this.rTB2.ReadOnly = true;
            this.rTB2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTB2.Size = new System.Drawing.Size(952, 123);
            this.rTB2.TabIndex = 3;
            this.rTB2.Text = resources.GetString("rTB2.Text");
            // 
            // Usage_Instructions_label
            // 
            this.Usage_Instructions_label.AutoSize = true;
            this.Usage_Instructions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usage_Instructions_label.Location = new System.Drawing.Point(43, 260);
            this.Usage_Instructions_label.Name = "Usage_Instructions_label";
            this.Usage_Instructions_label.Size = new System.Drawing.Size(166, 20);
            this.Usage_Instructions_label.TabIndex = 4;
            this.Usage_Instructions_label.Text = "Usage Instructions:";
            // 
            // rTB3
            // 
            this.rTB3.BackColor = System.Drawing.SystemColors.Control;
            this.rTB3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTB3.Location = new System.Drawing.Point(56, 283);
            this.rTB3.Name = "rTB3";
            this.rTB3.ReadOnly = true;
            this.rTB3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTB3.Size = new System.Drawing.Size(952, 257);
            this.rTB3.TabIndex = 5;
            this.rTB3.Text = resources.GetString("rTB3.Text");
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 598);
            this.Controls.Add(this.rTB3);
            this.Controls.Add(this.Usage_Instructions_label);
            this.Controls.Add(this.rTB2);
            this.Controls.Add(this.Key_Features_label);
            this.Controls.Add(this.rTB1);
            this.Controls.Add(this.Software_Descriptionlabel);
            this.Name = "Helper";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Software_Descriptionlabel;
        private System.Windows.Forms.RichTextBox rTB1;
        private System.Windows.Forms.Label Key_Features_label;
        private System.Windows.Forms.RichTextBox rTB2;
        private System.Windows.Forms.Label Usage_Instructions_label;
        private System.Windows.Forms.RichTextBox rTB3;
    }
}