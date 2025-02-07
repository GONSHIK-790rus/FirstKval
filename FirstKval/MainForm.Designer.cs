namespace FirstKval
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            partnersLayoutPanel = new FlowLayoutPanel();
            Tip_Label = new Label();
            TypeOfTitleForEdit_TextBox = new TextBox();
            CompanyOfTitleForEdit_TextBox = new TextBox();
            MainPanel = new Panel();
            LogoPanel = new Panel();
            EmptyPanel = new Panel();
            CompanyType_Label = new Label();
            CompanyName_Label = new Label();
            DirectorName_Label = new Label();
            Director_TextBox = new TextBox();
            PhoneNumber_TextBox = new TextBox();
            PhoneNumber_Label = new Label();
            Rating_TextBox = new TextBox();
            Rating_Label = new Label();
            Discount_Label = new Label();
            SoldProd_TextBox = new TextBox();
            SoldProd_Label = new Label();
            DiscountValue_Label = new Label();
            partnersLayoutPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // partnersLayoutPanel
            // 
            partnersLayoutPanel.AutoScroll = true;
            partnersLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            partnersLayoutPanel.Controls.Add(Tip_Label);
            partnersLayoutPanel.Dock = DockStyle.Left;
            partnersLayoutPanel.Location = new Point(0, 110);
            partnersLayoutPanel.Name = "partnersLayoutPanel";
            partnersLayoutPanel.Size = new Size(527, 426);
            partnersLayoutPanel.TabIndex = 0;
            // 
            // Tip_Label
            // 
            Tip_Label.AutoSize = true;
            Tip_Label.ForeColor = SystemColors.Highlight;
            Tip_Label.Location = new Point(3, 0);
            Tip_Label.Name = "Tip_Label";
            Tip_Label.Size = new Size(304, 15);
            Tip_Label.TabIndex = 0;
            Tip_Label.Text = "* Нажмите на карточку чтобы редактировать/удалить";
            // 
            // TypeOfTitleForEdit_TextBox
            // 
            TypeOfTitleForEdit_TextBox.Location = new Point(758, 157);
            TypeOfTitleForEdit_TextBox.Name = "TypeOfTitleForEdit_TextBox";
            TypeOfTitleForEdit_TextBox.Size = new Size(170, 23);
            TypeOfTitleForEdit_TextBox.TabIndex = 1;
            // 
            // CompanyOfTitleForEdit_TextBox
            // 
            CompanyOfTitleForEdit_TextBox.Location = new Point(758, 197);
            CompanyOfTitleForEdit_TextBox.Name = "CompanyOfTitleForEdit_TextBox";
            CompanyOfTitleForEdit_TextBox.Size = new Size(170, 23);
            CompanyOfTitleForEdit_TextBox.TabIndex = 2;
            // 
            // MainPanel
            // 
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(LogoPanel);
            MainPanel.Controls.Add(EmptyPanel);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1041, 110);
            MainPanel.TabIndex = 3;
            // 
            // LogoPanel
            // 
            LogoPanel.BackgroundImage = Properties.Resources.apple_logo_original;
            LogoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            LogoPanel.Dock = DockStyle.Left;
            LogoPanel.Location = new Point(16, 0);
            LogoPanel.Margin = new Padding(15, 3, 3, 3);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(221, 108);
            LogoPanel.TabIndex = 0;
            // 
            // EmptyPanel
            // 
            EmptyPanel.BackgroundImageLayout = ImageLayout.Zoom;
            EmptyPanel.Dock = DockStyle.Left;
            EmptyPanel.Location = new Point(0, 0);
            EmptyPanel.Margin = new Padding(15, 3, 3, 3);
            EmptyPanel.Name = "EmptyPanel";
            EmptyPanel.Size = new Size(16, 108);
            EmptyPanel.TabIndex = 1;
            // 
            // CompanyType_Label
            // 
            CompanyType_Label.AutoSize = true;
            CompanyType_Label.Location = new Point(722, 160);
            CompanyType_Label.Name = "CompanyType_Label";
            CompanyType_Label.Size = new Size(30, 15);
            CompanyType_Label.TabIndex = 4;
            CompanyType_Label.Text = "Тип:";
            // 
            // CompanyName_Label
            // 
            CompanyName_Label.AutoSize = true;
            CompanyName_Label.Location = new Point(631, 200);
            CompanyName_Label.Name = "CompanyName_Label";
            CompanyName_Label.Size = new Size(121, 15);
            CompanyName_Label.TabIndex = 5;
            CompanyName_Label.Text = "Название компании:";
            // 
            // DirectorName_Label
            // 
            DirectorName_Label.AutoSize = true;
            DirectorName_Label.Location = new Point(666, 240);
            DirectorName_Label.Name = "DirectorName_Label";
            DirectorName_Label.Size = new Size(86, 15);
            DirectorName_Label.TabIndex = 6;
            DirectorName_Label.Text = "Ген. директор:";
            // 
            // Director_TextBox
            // 
            Director_TextBox.Location = new Point(758, 237);
            Director_TextBox.Name = "Director_TextBox";
            Director_TextBox.Size = new Size(170, 23);
            Director_TextBox.TabIndex = 7;
            // 
            // PhoneNumber_TextBox
            // 
            PhoneNumber_TextBox.Location = new Point(758, 277);
            PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            PhoneNumber_TextBox.Size = new Size(170, 23);
            PhoneNumber_TextBox.TabIndex = 8;
            // 
            // PhoneNumber_Label
            // 
            PhoneNumber_Label.AutoSize = true;
            PhoneNumber_Label.Location = new Point(648, 280);
            PhoneNumber_Label.Name = "PhoneNumber_Label";
            PhoneNumber_Label.Size = new Size(104, 15);
            PhoneNumber_Label.TabIndex = 9;
            PhoneNumber_Label.Text = "Номер телефона:";
            // 
            // Rating_TextBox
            // 
            Rating_TextBox.Location = new Point(758, 317);
            Rating_TextBox.Name = "Rating_TextBox";
            Rating_TextBox.Size = new Size(170, 23);
            Rating_TextBox.TabIndex = 10;
            // 
            // Rating_Label
            // 
            Rating_Label.AutoSize = true;
            Rating_Label.Location = new Point(698, 320);
            Rating_Label.Name = "Rating_Label";
            Rating_Label.Size = new Size(54, 15);
            Rating_Label.TabIndex = 11;
            Rating_Label.Text = "Рейтинг:";
            // 
            // Discount_Label
            // 
            Discount_Label.AutoSize = true;
            Discount_Label.Location = new Point(703, 360);
            Discount_Label.Name = "Discount_Label";
            Discount_Label.Size = new Size(49, 15);
            Discount_Label.TabIndex = 13;
            Discount_Label.Text = "Скидка:";
            // 
            // SoldProd_TextBox
            // 
            SoldProd_TextBox.Location = new Point(758, 397);
            SoldProd_TextBox.Name = "SoldProd_TextBox";
            SoldProd_TextBox.Size = new Size(170, 23);
            SoldProd_TextBox.TabIndex = 14;
            SoldProd_TextBox.KeyPress += SoldProd_TextBox_KeyPress;
            // 
            // SoldProd_Label
            // 
            SoldProd_Label.AutoSize = true;
            SoldProd_Label.Location = new Point(630, 400);
            SoldProd_Label.Name = "SoldProd_Label";
            SoldProd_Label.Size = new Size(122, 15);
            SoldProd_Label.TabIndex = 15;
            SoldProd_Label.Text = "Продано продукции:";
            // 
            // DiscountValue_Label
            // 
            DiscountValue_Label.AutoSize = true;
            DiscountValue_Label.Location = new Point(758, 360);
            DiscountValue_Label.Name = "DiscountValue_Label";
            DiscountValue_Label.Size = new Size(23, 15);
            DiscountValue_Label.TabIndex = 16;
            DiscountValue_Label.Text = "0%";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1041, 536);
            Controls.Add(DiscountValue_Label);
            Controls.Add(SoldProd_Label);
            Controls.Add(SoldProd_TextBox);
            Controls.Add(Discount_Label);
            Controls.Add(Rating_Label);
            Controls.Add(Rating_TextBox);
            Controls.Add(PhoneNumber_Label);
            Controls.Add(PhoneNumber_TextBox);
            Controls.Add(Director_TextBox);
            Controls.Add(DirectorName_Label);
            Controls.Add(CompanyName_Label);
            Controls.Add(CompanyType_Label);
            Controls.Add(CompanyOfTitleForEdit_TextBox);
            Controls.Add(TypeOfTitleForEdit_TextBox);
            Controls.Add(partnersLayoutPanel);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Список партнеров";
            partnersLayoutPanel.ResumeLayout(false);
            partnersLayoutPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel partnersLayoutPanel;
        private TextBox TypeOfTitleForEdit_TextBox;
        private TextBox CompanyOfTitleForEdit_TextBox;
        private Panel MainPanel;
        private Panel LogoPanel;
        private Panel EmptyPanel;
        private Label CompanyType_Label;
        private Label CompanyName_Label;
        private Label DirectorName_Label;
        private TextBox Director_TextBox;
        private TextBox PhoneNumber_TextBox;
        private Label PhoneNumber_Label;
        private TextBox Rating_TextBox;
        private Label Rating_Label;
        private Label Discount_Label;
        private TextBox textBox1;
        private TextBox SoldProd_TextBox;
        private Label SoldProd_Label;
        private Label DiscountValue_Label;
        private Label Tip_Label;
    }
}
