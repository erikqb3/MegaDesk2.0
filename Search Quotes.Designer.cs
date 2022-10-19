namespace MegaDesk2._0
{
    partial class Search_Quotes
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
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.searchQuotesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(12, 12);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(121, 28);
            this.materialComboBox.TabIndex = 0;
            this.materialComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // searchQuotesDataGrid
            // 
            this.searchQuotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesDataGrid.Location = new System.Drawing.Point(12, 46);
            this.searchQuotesDataGrid.Name = "searchQuotesDataGrid";
            this.searchQuotesDataGrid.RowHeadersWidth = 62;
            this.searchQuotesDataGrid.RowTemplate.Height = 28;
            this.searchQuotesDataGrid.Size = new System.Drawing.Size(776, 392);
            this.searchQuotesDataGrid.TabIndex = 1;
            // 
            // Search_Quotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchQuotesDataGrid);
            this.Controls.Add(this.materialComboBox);
            this.Name = "Search_Quotes";
            this.Text = "Search_Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Quotes_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_Quotes_FormClosed);
            this.Load += new System.EventHandler(this.Search_Quotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.DataGridView searchQuotesDataGrid;
    }
}