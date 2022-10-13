namespace MegaDesk2._0
{
    partial class View_All_Quotes
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
            this.allQuotesText = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.allQuotesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allQuotesText
            // 
            this.allQuotesText.AutoSize = true;
            this.allQuotesText.Location = new System.Drawing.Point(28, 65);
            this.allQuotesText.Name = "allQuotesText";
            this.allQuotesText.Size = new System.Drawing.Size(152, 20);
            this.allQuotesText.TabIndex = 0;
            this.allQuotesText.Text = "No Quotes Available";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(865, 65);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 488);
            this.vScrollBar1.TabIndex = 1;
            // 
            // allQuotesLabel
            // 
            this.allQuotesLabel.AutoSize = true;
            this.allQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allQuotesLabel.Location = new System.Drawing.Point(27, 13);
            this.allQuotesLabel.Name = "allQuotesLabel";
            this.allQuotesLabel.Size = new System.Drawing.Size(113, 25);
            this.allQuotesLabel.TabIndex = 2;
            this.allQuotesLabel.Text = "All Quotes";
            // 
            // View_All_Quotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.allQuotesLabel);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.allQuotesText);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View_All_Quotes";
            this.Text = "View_All_Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.View_All_Quotes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label allQuotesText;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label allQuotesLabel;
    }
}