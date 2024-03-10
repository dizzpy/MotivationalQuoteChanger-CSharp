namespace MotivationalQuoteChanger
{
    partial class Form1
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
            this.quoteLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quoteLabel
            // 
            this.quoteLabel.AllowDrop = true;
            this.quoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quoteLabel.Location = new System.Drawing.Point(183, 171);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(739, 34);
            this.quoteLabel.TabIndex = 1;
            this.quoteLabel.Text = "\"You are never too old to set another goal or to dream a new dream.\"";
            this.quoteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // authorLabel
            // 
            this.authorLabel.AllowDrop = true;
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(183, 213);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(64, 28);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 451);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.quoteLabel);
            this.Name = "Form1";
            this.Text = "Motivational Quote Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label quoteLabel;
        private System.Windows.Forms.Label authorLabel;
    }
}

