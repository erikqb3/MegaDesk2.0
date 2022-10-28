namespace MegaDesk2._0
{
    partial class Add_Quote
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
            System.Windows.Forms.Button cancel_btn;
            this.getQuote_btn = new System.Windows.Forms.Button();
            this.width_input = new System.Windows.Forms.NumericUpDown();
            this.deskProperties_box = new System.Windows.Forms.GroupBox();
            this.material_label = new System.Windows.Forms.Label();
            this.rushOrder_no = new System.Windows.Forms.RadioButton();
            this.rushOrder_label = new System.Windows.Forms.Label();
            this.material_input = new System.Windows.Forms.ComboBox();
            this.days_label = new System.Windows.Forms.Label();
            this.days_input = new System.Windows.Forms.ComboBox();
            this.rushOrder_yes = new System.Windows.Forms.RadioButton();
            this.drawerCount_label = new System.Windows.Forms.Label();
            this.depth_label = new System.Windows.Forms.Label();
            this.depth_input = new System.Windows.Forms.NumericUpDown();
            this.drawerCount_input = new System.Windows.Forms.NumericUpDown();
            this.width_label = new System.Windows.Forms.Label();
            this.clientInfoBox = new System.Windows.Forms.GroupBox();
            this.currentDate_label = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.RadioButton();
            this.phone_input = new System.Windows.Forms.RadioButton();
            this.contactData_input = new System.Windows.Forms.TextBox();
            this.contactData_label = new System.Windows.Forms.Label();
            this.contactInfo_label = new System.Windows.Forms.Label();
            this.fullName_input = new System.Windows.Forms.TextBox();
            this.clientName_label = new System.Windows.Forms.Label();
            this.PricingBox = new System.Windows.Forms.GroupBox();
            this.finishDate_value = new System.Windows.Forms.Label();
            this.finishDate_label = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.taxCost = new System.Windows.Forms.Label();
            this.sumCost = new System.Windows.Forms.Label();
            this.rushCost = new System.Windows.Forms.Label();
            this.materialCost = new System.Windows.Forms.Label();
            this.drawerCost = new System.Windows.Forms.Label();
            this.sizeCost = new System.Windows.Forms.Label();
            this.baseCost = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width_input)).BeginInit();
            this.deskProperties_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount_input)).BeginInit();
            this.clientInfoBox.SuspendLayout();
            this.PricingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new System.Drawing.Point(226, 390);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new System.Drawing.Size(162, 48);
            cancel_btn.TabIndex = 11;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // getQuote_btn
            // 
            this.getQuote_btn.Location = new System.Drawing.Point(426, 389);
            this.getQuote_btn.Name = "getQuote_btn";
            this.getQuote_btn.Size = new System.Drawing.Size(162, 50);
            this.getQuote_btn.TabIndex = 12;
            this.getQuote_btn.Text = "Get Quote";
            this.getQuote_btn.UseVisualStyleBackColor = true;
            this.getQuote_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // width_input
            // 
            this.width_input.Location = new System.Drawing.Point(163, 34);
            this.width_input.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.width_input.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width_input.Name = "width_input";
            this.width_input.Size = new System.Drawing.Size(72, 22);
            this.width_input.TabIndex = 5;
            this.width_input.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width_input.ValueChanged += new System.EventHandler(this.width_input_ValueChanged);
            // 
            // deskProperties_box
            // 
            this.deskProperties_box.BackColor = System.Drawing.SystemColors.Control;
            this.deskProperties_box.Controls.Add(this.material_label);
            this.deskProperties_box.Controls.Add(this.rushOrder_no);
            this.deskProperties_box.Controls.Add(this.rushOrder_label);
            this.deskProperties_box.Controls.Add(this.material_input);
            this.deskProperties_box.Controls.Add(this.days_label);
            this.deskProperties_box.Controls.Add(this.days_input);
            this.deskProperties_box.Controls.Add(this.rushOrder_yes);
            this.deskProperties_box.Controls.Add(this.drawerCount_label);
            this.deskProperties_box.Controls.Add(this.depth_label);
            this.deskProperties_box.Controls.Add(this.depth_input);
            this.deskProperties_box.Controls.Add(this.drawerCount_input);
            this.deskProperties_box.Controls.Add(this.width_label);
            this.deskProperties_box.Controls.Add(this.width_input);
            this.deskProperties_box.Location = new System.Drawing.Point(280, 37);
            this.deskProperties_box.Name = "deskProperties_box";
            this.deskProperties_box.Size = new System.Drawing.Size(256, 347);
            this.deskProperties_box.TabIndex = 3;
            this.deskProperties_box.TabStop = false;
            this.deskProperties_box.Text = "Desk Properties";
            // 
            // material_label
            // 
            this.material_label.AutoSize = true;
            this.material_label.Location = new System.Drawing.Point(21, 153);
            this.material_label.Name = "material_label";
            this.material_label.Size = new System.Drawing.Size(55, 16);
            this.material_label.TabIndex = 17;
            this.material_label.Text = "Material";
            // 
            // rushOrder_no
            // 
            this.rushOrder_no.AutoSize = true;
            this.rushOrder_no.Location = new System.Drawing.Point(79, 257);
            this.rushOrder_no.Name = "rushOrder_no";
            this.rushOrder_no.Size = new System.Drawing.Size(46, 20);
            this.rushOrder_no.TabIndex = 10;
            this.rushOrder_no.Text = "No";
            this.rushOrder_no.UseVisualStyleBackColor = true;
            this.rushOrder_no.Click += new System.EventHandler(this.rushOrder_no_Click);
            // 
            // rushOrder_label
            // 
            this.rushOrder_label.AutoSize = true;
            this.rushOrder_label.Location = new System.Drawing.Point(21, 237);
            this.rushOrder_label.Name = "rushOrder_label";
            this.rushOrder_label.Size = new System.Drawing.Size(75, 16);
            this.rushOrder_label.TabIndex = 19;
            this.rushOrder_label.Text = "Rush Order";
            // 
            // material_input
            // 
            this.material_input.FormattingEnabled = true;
            this.material_input.Location = new System.Drawing.Point(24, 174);
            this.material_input.Name = "material_input";
            this.material_input.Size = new System.Drawing.Size(211, 24);
            this.material_input.TabIndex = 8;
            this.material_input.SelectedIndexChanged += new System.EventHandler(this.material_input_SelectedIndexChanged);
            // 
            // days_label
            // 
            this.days_label.AutoSize = true;
            this.days_label.Location = new System.Drawing.Point(196, 237);
            this.days_label.Name = "days_label";
            this.days_label.Size = new System.Drawing.Size(39, 16);
            this.days_label.TabIndex = 23;
            this.days_label.Text = "Days";
            // 
            // days_input
            // 
            this.days_input.FormattingEnabled = true;
            this.days_input.Location = new System.Drawing.Point(163, 256);
            this.days_input.Name = "days_input";
            this.days_input.Size = new System.Drawing.Size(72, 24);
            this.days_input.TabIndex = 11;
            this.days_input.SelectedIndexChanged += new System.EventHandler(this.days_input_SelectedIndexChanged);
            // 
            // rushOrder_yes
            // 
            this.rushOrder_yes.AutoSize = true;
            this.rushOrder_yes.Location = new System.Drawing.Point(24, 256);
            this.rushOrder_yes.Name = "rushOrder_yes";
            this.rushOrder_yes.Size = new System.Drawing.Size(52, 20);
            this.rushOrder_yes.TabIndex = 9;
            this.rushOrder_yes.Text = "Yes";
            this.rushOrder_yes.UseVisualStyleBackColor = true;
            this.rushOrder_yes.Click += new System.EventHandler(this.rushOrder_yes_Click);
            // 
            // drawerCount_label
            // 
            this.drawerCount_label.AutoSize = true;
            this.drawerCount_label.Location = new System.Drawing.Point(21, 111);
            this.drawerCount_label.Name = "drawerCount_label";
            this.drawerCount_label.Size = new System.Drawing.Size(87, 16);
            this.drawerCount_label.TabIndex = 16;
            this.drawerCount_label.Text = "Drawer Count";
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Location = new System.Drawing.Point(21, 75);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(43, 16);
            this.depth_label.TabIndex = 5;
            this.depth_label.Text = "Depth";
            // 
            // depth_input
            // 
            this.depth_input.Location = new System.Drawing.Point(163, 69);
            this.depth_input.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depth_input.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth_input.Name = "depth_input";
            this.depth_input.Size = new System.Drawing.Size(72, 22);
            this.depth_input.TabIndex = 6;
            this.depth_input.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth_input.ValueChanged += new System.EventHandler(this.depth_input_ValueChanged);
            // 
            // drawerCount_input
            // 
            this.drawerCount_input.Location = new System.Drawing.Point(163, 109);
            this.drawerCount_input.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerCount_input.Name = "drawerCount_input";
            this.drawerCount_input.Size = new System.Drawing.Size(72, 22);
            this.drawerCount_input.TabIndex = 7;
            this.drawerCount_input.ValueChanged += new System.EventHandler(this.drawerCount_input_ValueChanged);
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Location = new System.Drawing.Point(21, 40);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(41, 16);
            this.width_label.TabIndex = 3;
            this.width_label.Text = "Width";
            // 
            // clientInfoBox
            // 
            this.clientInfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.clientInfoBox.Controls.Add(this.currentDate_label);
            this.clientInfoBox.Controls.Add(this.email_input);
            this.clientInfoBox.Controls.Add(this.phone_input);
            this.clientInfoBox.Controls.Add(this.contactData_input);
            this.clientInfoBox.Controls.Add(this.contactData_label);
            this.clientInfoBox.Controls.Add(this.contactInfo_label);
            this.clientInfoBox.Controls.Add(this.fullName_input);
            this.clientInfoBox.Controls.Add(this.clientName_label);
            this.clientInfoBox.Location = new System.Drawing.Point(12, 37);
            this.clientInfoBox.Name = "clientInfoBox";
            this.clientInfoBox.Size = new System.Drawing.Size(256, 347);
            this.clientInfoBox.TabIndex = 4;
            this.clientInfoBox.TabStop = false;
            this.clientInfoBox.Text = "Client Info";
            // 
            // currentDate_label
            // 
            this.currentDate_label.AutoSize = true;
            this.currentDate_label.Location = new System.Drawing.Point(62, 309);
            this.currentDate_label.Name = "currentDate_label";
            this.currentDate_label.Size = new System.Drawing.Size(74, 16);
            this.currentDate_label.TabIndex = 9;
            this.currentDate_label.Text = "CurentDate";
            this.currentDate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_input
            // 
            this.email_input.AutoSize = true;
            this.email_input.Location = new System.Drawing.Point(100, 113);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(62, 20);
            this.email_input.TabIndex = 3;
            this.email_input.TabStop = true;
            this.email_input.Text = "Email";
            this.email_input.UseVisualStyleBackColor = true;
            this.email_input.Click += new System.EventHandler(this.email_input_Click);
            // 
            // phone_input
            // 
            this.phone_input.AutoSize = true;
            this.phone_input.Location = new System.Drawing.Point(18, 113);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(67, 20);
            this.phone_input.TabIndex = 2;
            this.phone_input.TabStop = true;
            this.phone_input.Text = "Phone";
            this.phone_input.UseVisualStyleBackColor = true;
            this.phone_input.Click += new System.EventHandler(this.phone_input_Click);
            // 
            // contactData_input
            // 
            this.contactData_input.Enabled = false;
            this.contactData_input.Location = new System.Drawing.Point(18, 179);
            this.contactData_input.Name = "contactData_input";
            this.contactData_input.Size = new System.Drawing.Size(218, 22);
            this.contactData_input.TabIndex = 4;
            // 
            // contactData_label
            // 
            this.contactData_label.AutoSize = true;
            this.contactData_label.Location = new System.Drawing.Point(18, 160);
            this.contactData_label.Name = "contactData_label";
            this.contactData_label.Size = new System.Drawing.Size(97, 16);
            this.contactData_label.TabIndex = 5;
            this.contactData_label.Text = "Phone Number";
            // 
            // contactInfo_label
            // 
            this.contactInfo_label.AutoSize = true;
            this.contactInfo_label.Location = new System.Drawing.Point(15, 94);
            this.contactInfo_label.Name = "contactInfo_label";
            this.contactInfo_label.Size = new System.Drawing.Size(76, 16);
            this.contactInfo_label.TabIndex = 3;
            this.contactInfo_label.Text = "Contact Info";
            // 
            // fullName_input
            // 
            this.fullName_input.Location = new System.Drawing.Point(65, 57);
            this.fullName_input.Name = "fullName_input";
            this.fullName_input.Size = new System.Drawing.Size(171, 22);
            this.fullName_input.TabIndex = 1;
            // 
            // clientName_label
            // 
            this.clientName_label.AutoSize = true;
            this.clientName_label.Location = new System.Drawing.Point(15, 44);
            this.clientName_label.Name = "clientName_label";
            this.clientName_label.Size = new System.Drawing.Size(44, 32);
            this.clientName_label.TabIndex = 0;
            this.clientName_label.Text = "Full\r\nName";
            // 
            // PricingBox
            // 
            this.PricingBox.BackColor = System.Drawing.SystemColors.Control;
            this.PricingBox.Controls.Add(this.finishDate_value);
            this.PricingBox.Controls.Add(this.finishDate_label);
            this.PricingBox.Controls.Add(this.totalCost);
            this.PricingBox.Controls.Add(this.taxCost);
            this.PricingBox.Controls.Add(this.sumCost);
            this.PricingBox.Controls.Add(this.rushCost);
            this.PricingBox.Controls.Add(this.materialCost);
            this.PricingBox.Controls.Add(this.drawerCost);
            this.PricingBox.Controls.Add(this.sizeCost);
            this.PricingBox.Controls.Add(this.baseCost);
            this.PricingBox.Controls.Add(this.label15);
            this.PricingBox.Controls.Add(this.label14);
            this.PricingBox.Controls.Add(this.label13);
            this.PricingBox.Controls.Add(this.label12);
            this.PricingBox.Controls.Add(this.label11);
            this.PricingBox.Controls.Add(this.label10);
            this.PricingBox.Controls.Add(this.label9);
            this.PricingBox.Controls.Add(this.label8);
            this.PricingBox.Location = new System.Drawing.Point(548, 37);
            this.PricingBox.Name = "PricingBox";
            this.PricingBox.Size = new System.Drawing.Size(256, 347);
            this.PricingBox.TabIndex = 13;
            this.PricingBox.TabStop = false;
            this.PricingBox.Text = "Quote";
            // 
            // finishDate_value
            // 
            this.finishDate_value.Location = new System.Drawing.Point(106, 302);
            this.finishDate_value.Name = "finishDate_value";
            this.finishDate_value.Size = new System.Drawing.Size(130, 23);
            this.finishDate_value.TabIndex = 23;
            this.finishDate_value.Text = "FinishDate";
            this.finishDate_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // finishDate_label
            // 
            this.finishDate_label.AutoSize = true;
            this.finishDate_label.Location = new System.Drawing.Point(20, 305);
            this.finishDate_label.Name = "finishDate_label";
            this.finishDate_label.Size = new System.Drawing.Size(80, 16);
            this.finishDate_label.TabIndex = 22;
            this.finishDate_label.Text = "Finish Date: ";
            // 
            // totalCost
            // 
            this.totalCost.Location = new System.Drawing.Point(148, 265);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(88, 16);
            this.totalCost.TabIndex = 21;
            this.totalCost.Text = "$0.00";
            this.totalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxCost
            // 
            this.taxCost.Location = new System.Drawing.Point(148, 239);
            this.taxCost.Name = "taxCost";
            this.taxCost.Size = new System.Drawing.Size(88, 16);
            this.taxCost.TabIndex = 20;
            this.taxCost.Text = "$0.00";
            this.taxCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sumCost
            // 
            this.sumCost.Location = new System.Drawing.Point(148, 215);
            this.sumCost.Name = "sumCost";
            this.sumCost.Size = new System.Drawing.Size(88, 16);
            this.sumCost.TabIndex = 19;
            this.sumCost.Text = "$0.00";
            this.sumCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rushCost
            // 
            this.rushCost.Location = new System.Drawing.Point(148, 160);
            this.rushCost.Name = "rushCost";
            this.rushCost.Size = new System.Drawing.Size(88, 16);
            this.rushCost.TabIndex = 18;
            this.rushCost.Text = "$0.00";
            this.rushCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialCost
            // 
            this.materialCost.Location = new System.Drawing.Point(148, 132);
            this.materialCost.Name = "materialCost";
            this.materialCost.Size = new System.Drawing.Size(88, 16);
            this.materialCost.TabIndex = 17;
            this.materialCost.Text = "$0.00";
            this.materialCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawerCost
            // 
            this.drawerCost.Location = new System.Drawing.Point(148, 101);
            this.drawerCost.Name = "drawerCost";
            this.drawerCost.Size = new System.Drawing.Size(88, 16);
            this.drawerCost.TabIndex = 16;
            this.drawerCost.Text = "$0.00";
            this.drawerCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeCost
            // 
            this.sizeCost.Location = new System.Drawing.Point(137, 70);
            this.sizeCost.Name = "sizeCost";
            this.sizeCost.Size = new System.Drawing.Size(99, 16);
            this.sizeCost.TabIndex = 15;
            this.sizeCost.Text = "$0.00";
            this.sizeCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // baseCost
            // 
            this.baseCost.Location = new System.Drawing.Point(140, 31);
            this.baseCost.Name = "baseCost";
            this.baseCost.Size = new System.Drawing.Size(96, 26);
            this.baseCost.TabIndex = 14;
            this.baseCost.Text = "$0.00";
            this.baseCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Sum";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Rush Cost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Drawer Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Material Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Size Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Base Desk Price";
            // 
            // Add_Quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 464);
            this.Controls.Add(this.PricingBox);
            this.Controls.Add(this.clientInfoBox);
            this.Controls.Add(this.deskProperties_box);
            this.Controls.Add(cancel_btn);
            this.Controls.Add(this.getQuote_btn);
            this.Name = "Add_Quote";
            this.Text = "Add_Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Quote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.width_input)).EndInit();
            this.deskProperties_box.ResumeLayout(false);
            this.deskProperties_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount_input)).EndInit();
            this.clientInfoBox.ResumeLayout(false);
            this.clientInfoBox.PerformLayout();
            this.PricingBox.ResumeLayout(false);
            this.PricingBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getQuote_btn;
        private System.Windows.Forms.NumericUpDown width_input;
        private System.Windows.Forms.GroupBox deskProperties_box;
        private System.Windows.Forms.GroupBox clientInfoBox;
        private System.Windows.Forms.Label contactInfo_label;
        private System.Windows.Forms.TextBox fullName_input;
        private System.Windows.Forms.Label clientName_label;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.NumericUpDown depth_input;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.TextBox contactData_input;
        private System.Windows.Forms.Label contactData_label;
        private System.Windows.Forms.NumericUpDown drawerCount_input;
        private System.Windows.Forms.Label material_label;
        private System.Windows.Forms.RadioButton rushOrder_no;
        private System.Windows.Forms.Label rushOrder_label;
        private System.Windows.Forms.ComboBox material_input;
        private System.Windows.Forms.Label days_label;
        private System.Windows.Forms.ComboBox days_input;
        private System.Windows.Forms.RadioButton rushOrder_yes;
        private System.Windows.Forms.Label drawerCount_label;
        private System.Windows.Forms.RadioButton email_input;
        private System.Windows.Forms.RadioButton phone_input;
        private System.Windows.Forms.GroupBox PricingBox;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label taxCost;
        private System.Windows.Forms.Label sumCost;
        private System.Windows.Forms.Label rushCost;
        private System.Windows.Forms.Label materialCost;
        private System.Windows.Forms.Label drawerCost;
        private System.Windows.Forms.Label sizeCost;
        private System.Windows.Forms.Label baseCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label currentDate_label;
        private System.Windows.Forms.Label finishDate_label;
        private System.Windows.Forms.Label finishDate_value;
    }
}