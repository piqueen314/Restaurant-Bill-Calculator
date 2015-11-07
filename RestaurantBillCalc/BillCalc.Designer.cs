namespace RestaurantBillCalc
{
    partial class BillCalc
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
            this.appetizercComboBox = new System.Windows.Forms.ComboBox();
            this.appetizerLabel = new System.Windows.Forms.Label();
            this.beverageLabel = new System.Windows.Forms.Label();
            this.beverageComboBox = new System.Windows.Forms.ComboBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.dessertLabel = new System.Windows.Forms.Label();
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.mainCourseLabel = new System.Windows.Forms.Label();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.receiptGroupBox = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.receiptListBox = new System.Windows.Forms.ListBox();
            this.totalGropBox = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.clearBillButton = new System.Windows.Forms.Button();
            this.receiptGroupBox.SuspendLayout();
            this.totalGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appetizercComboBox
            // 
            this.appetizercComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appetizercComboBox.FormattingEnabled = true;
            this.appetizercComboBox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa",
            "Garlic Bread Bites",
            "Mac \'N Cheese Bites"});
            this.appetizercComboBox.Location = new System.Drawing.Point(30, 74);
            this.appetizercComboBox.Name = "appetizercComboBox";
            this.appetizercComboBox.Size = new System.Drawing.Size(121, 21);
            this.appetizercComboBox.TabIndex = 0;
            this.appetizercComboBox.SelectedIndexChanged += new System.EventHandler(this.appetizercComboBox_SelectedIndexChanged);
            // 
            // appetizerLabel
            // 
            this.appetizerLabel.AutoSize = true;
            this.appetizerLabel.Location = new System.Drawing.Point(30, 55);
            this.appetizerLabel.Name = "appetizerLabel";
            this.appetizerLabel.Size = new System.Drawing.Size(56, 13);
            this.appetizerLabel.TabIndex = 1;
            this.appetizerLabel.Text = "Appetizers";
            // 
            // beverageLabel
            // 
            this.beverageLabel.AutoSize = true;
            this.beverageLabel.Location = new System.Drawing.Point(159, 55);
            this.beverageLabel.Name = "beverageLabel";
            this.beverageLabel.Size = new System.Drawing.Size(58, 13);
            this.beverageLabel.TabIndex = 2;
            this.beverageLabel.Text = "Beverages";
            // 
            // beverageComboBox
            // 
            this.beverageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beverageComboBox.FormattingEnabled = true;
            this.beverageComboBox.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk",
            "Domestic Beer",
            "Fancy Beer"});
            this.beverageComboBox.Location = new System.Drawing.Point(157, 74);
            this.beverageComboBox.Name = "beverageComboBox";
            this.beverageComboBox.Size = new System.Drawing.Size(121, 21);
            this.beverageComboBox.TabIndex = 3;
            this.beverageComboBox.SelectedIndexChanged += new System.EventHandler(this.beverageComboBox_SelectedIndexChanged);
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.dessertComboBox.Location = new System.Drawing.Point(284, 74);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(121, 21);
            this.dessertComboBox.TabIndex = 4;
            this.dessertComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertComboBox_SelectedIndexChanged);
            // 
            // dessertLabel
            // 
            this.dessertLabel.AutoSize = true;
            this.dessertLabel.Location = new System.Drawing.Point(284, 54);
            this.dessertLabel.Name = "dessertLabel";
            this.dessertLabel.Size = new System.Drawing.Size(48, 13);
            this.dessertLabel.TabIndex = 5;
            this.dessertLabel.Text = "Desserts";
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Items.AddRange(new object[] {
            "Chicken Alfredo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken",
            "Seafood Alfredo"});
            this.mainCourseComboBox.Location = new System.Drawing.Point(411, 74);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(121, 21);
            this.mainCourseComboBox.TabIndex = 6;
            this.mainCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.mainCourseComboBox_SelectedIndexChanged);
            // 
            // mainCourseLabel
            // 
            this.mainCourseLabel.AutoSize = true;
            this.mainCourseLabel.Location = new System.Drawing.Point(412, 55);
            this.mainCourseLabel.Name = "mainCourseLabel";
            this.mainCourseLabel.Size = new System.Drawing.Size(71, 13);
            this.mainCourseLabel.TabIndex = 7;
            this.mainCourseLabel.Text = "Main Courses";
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Location = new System.Drawing.Point(17, 27);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(542, 111);
            this.menuGroupBox.TabIndex = 8;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu Items";
            // 
            // receiptGroupBox
            // 
            this.receiptGroupBox.Controls.Add(this.removeButton);
            this.receiptGroupBox.Controls.Add(this.receiptListBox);
            this.receiptGroupBox.Location = new System.Drawing.Point(17, 144);
            this.receiptGroupBox.Name = "receiptGroupBox";
            this.receiptGroupBox.Size = new System.Drawing.Size(332, 340);
            this.receiptGroupBox.TabIndex = 10;
            this.receiptGroupBox.TabStop = false;
            this.receiptGroupBox.Text = "receipt";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(268, 33);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // receiptListBox
            // 
            this.receiptListBox.FormattingEnabled = true;
            this.receiptListBox.Location = new System.Drawing.Point(13, 19);
            this.receiptListBox.Name = "receiptListBox";
            this.receiptListBox.Size = new System.Drawing.Size(248, 316);
            this.receiptListBox.TabIndex = 0;
            // 
            // totalGropBox
            // 
            this.totalGropBox.Controls.Add(this.totalTextBox);
            this.totalGropBox.Controls.Add(this.taxTextBox);
            this.totalGropBox.Controls.Add(this.subtotalTextBox);
            this.totalGropBox.Controls.Add(this.totalLabel);
            this.totalGropBox.Controls.Add(this.taxLabel);
            this.totalGropBox.Controls.Add(this.subtotalLabel);
            this.totalGropBox.Controls.Add(this.clearBillButton);
            this.totalGropBox.Location = new System.Drawing.Point(363, 145);
            this.totalGropBox.Name = "totalGropBox";
            this.totalGropBox.Size = new System.Drawing.Size(200, 265);
            this.totalGropBox.TabIndex = 11;
            this.totalGropBox.TabStop = false;
            this.totalGropBox.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(13, 174);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 6;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(13, 116);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 5;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(13, 61);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalTextBox.TabIndex = 4;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(16, 158);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(16, 100);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Tax";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(16, 45);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 1;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // clearBillButton
            // 
            this.clearBillButton.Location = new System.Drawing.Point(13, 218);
            this.clearBillButton.Name = "clearBillButton";
            this.clearBillButton.Size = new System.Drawing.Size(100, 23);
            this.clearBillButton.TabIndex = 0;
            this.clearBillButton.Text = "Clear Bill";
            this.clearBillButton.UseVisualStyleBackColor = true;
            this.clearBillButton.Click += new System.EventHandler(this.clearBillButton_Click);
            // 
            // BillCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 496);
            this.Controls.Add(this.totalGropBox);
            this.Controls.Add(this.mainCourseLabel);
            this.Controls.Add(this.mainCourseComboBox);
            this.Controls.Add(this.dessertLabel);
            this.Controls.Add(this.dessertComboBox);
            this.Controls.Add(this.beverageComboBox);
            this.Controls.Add(this.beverageLabel);
            this.Controls.Add(this.appetizerLabel);
            this.Controls.Add(this.appetizercComboBox);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.receiptGroupBox);
            this.Name = "BillCalc";
            this.Text = "Bill Calculator";
            this.receiptGroupBox.ResumeLayout(false);
            this.totalGropBox.ResumeLayout(false);
            this.totalGropBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox appetizercComboBox;
        private System.Windows.Forms.Label appetizerLabel;
        private System.Windows.Forms.Label beverageLabel;
        private System.Windows.Forms.ComboBox beverageComboBox;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.Label dessertLabel;
        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.Label mainCourseLabel;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.GroupBox receiptGroupBox;
        private System.Windows.Forms.GroupBox totalGropBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button clearBillButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox receiptListBox;
    }
}

