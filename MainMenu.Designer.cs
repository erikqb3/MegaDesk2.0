namespace MegaDesk1._0
{
    partial class MainMenu
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
            this.addQuote_btn = new System.Windows.Forms.Button();
            this.viewQuote_btn = new System.Windows.Forms.Button();
            this.searchQuote_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.menuImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuImg)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote_btn
            // 
            this.addQuote_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuote_btn.Location = new System.Drawing.Point(48, 51);
            this.addQuote_btn.Name = "addQuote_btn";
            this.addQuote_btn.Size = new System.Drawing.Size(301, 81);
            this.addQuote_btn.TabIndex = 0;
            this.addQuote_btn.Text = "Add New Quote";
            this.addQuote_btn.UseVisualStyleBackColor = true;
            this.addQuote_btn.Click += new System.EventHandler(this.addQuote_btn_Click);
            // 
            // viewQuote_btn
            // 
            this.viewQuote_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuote_btn.Location = new System.Drawing.Point(48, 150);
            this.viewQuote_btn.Name = "viewQuote_btn";
            this.viewQuote_btn.Size = new System.Drawing.Size(301, 81);
            this.viewQuote_btn.TabIndex = 1;
            this.viewQuote_btn.Text = "View All Quotes";
            this.viewQuote_btn.UseVisualStyleBackColor = true;
            this.viewQuote_btn.Click += new System.EventHandler(this.viewQuote_btn_Click);
            // 
            // searchQuote_btn
            // 
            this.searchQuote_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuote_btn.Location = new System.Drawing.Point(48, 250);
            this.searchQuote_btn.Name = "searchQuote_btn";
            this.searchQuote_btn.Size = new System.Drawing.Size(301, 81);
            this.searchQuote_btn.TabIndex = 2;
            this.searchQuote_btn.Text = "Search Quote";
            this.searchQuote_btn.UseVisualStyleBackColor = true;
            this.searchQuote_btn.Click += new System.EventHandler(this.searchQuote_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(48, 352);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(301, 81);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // menuImg
            // 
            this.menuImg.Location = new System.Drawing.Point(421, 51);
            this.menuImg.Name = "menuImg";
            this.menuImg.Size = new System.Drawing.Size(322, 307);
            this.menuImg.TabIndex = 4;
            this.menuImg.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.menuImg);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.searchQuote_btn);
            this.Controls.Add(this.viewQuote_btn);
            this.Controls.Add(this.addQuote_btn);
            this.Name = "MainMenu";
            this.Text = "Mega Desk Co.";
            ((System.ComponentModel.ISupportInitialize)(this.menuImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuote_btn;
        private System.Windows.Forms.Button viewQuote_btn;
        private System.Windows.Forms.Button searchQuote_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox menuImg;
    }
}

