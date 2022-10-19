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
            this.allQuotesLabel = new System.Windows.Forms.Label();
            this.allQuotesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesDataGrid)).BeginInit();
            this.SuspendLayout();
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
            // allQuotesDataGrid
            // 
            this.allQuotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuotesDataGrid.Location = new System.Drawing.Point(12, 41);
            this.allQuotesDataGrid.Name = "allQuotesDataGrid";
            this.allQuotesDataGrid.RowHeadersWidth = 62;
            this.allQuotesDataGrid.RowTemplate.Height = 28;
            this.allQuotesDataGrid.Size = new System.Drawing.Size(876, 509);
            this.allQuotesDataGrid.TabIndex = 3;
            // 
            // View_All_Quotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.allQuotesDataGrid);
            this.Controls.Add(this.allQuotesLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View_All_Quotes";
            this.Text = "View_All_Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.View_All_Quotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label allQuotesLabel;
        private System.Windows.Forms.DataGridView allQuotesDataGrid;
    }
}