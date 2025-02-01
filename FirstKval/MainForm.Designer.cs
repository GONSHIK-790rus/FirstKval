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
            partnersLayoutPanel = new FlowLayoutPanel();
            TypeOfTitleForEdit_TextBox = new TextBox();
            CompanyOfTitleForEdit_TextBox = new TextBox();
            SuspendLayout();
            // 
            // partnersLayoutPanel
            // 
            partnersLayoutPanel.AutoScroll = true;
            partnersLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            partnersLayoutPanel.Dock = DockStyle.Left;
            partnersLayoutPanel.Location = new Point(0, 0);
            partnersLayoutPanel.Name = "partnersLayoutPanel";
            partnersLayoutPanel.Size = new Size(527, 536);
            partnersLayoutPanel.TabIndex = 0;
            // 
            // TypeOfTitleForEdit_TextBox
            // 
            TypeOfTitleForEdit_TextBox.Location = new Point(717, 91);
            TypeOfTitleForEdit_TextBox.Name = "TypeOfTitleForEdit_TextBox";
            TypeOfTitleForEdit_TextBox.Size = new Size(170, 23);
            TypeOfTitleForEdit_TextBox.TabIndex = 1;
            // 
            // CompanyOfTitleForEdit_TextBox
            // 
            CompanyOfTitleForEdit_TextBox.Location = new Point(717, 129);
            CompanyOfTitleForEdit_TextBox.Name = "CompanyOfTitleForEdit_TextBox";
            CompanyOfTitleForEdit_TextBox.Size = new Size(170, 23);
            CompanyOfTitleForEdit_TextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(1041, 536);
            Controls.Add(CompanyOfTitleForEdit_TextBox);
            Controls.Add(TypeOfTitleForEdit_TextBox);
            Controls.Add(partnersLayoutPanel);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel partnersLayoutPanel;
        private TextBox TypeOfTitleForEdit_TextBox;
        private TextBox CompanyOfTitleForEdit_TextBox;
    }
}
