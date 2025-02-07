namespace FirstKval;

public partial class EditForm : Form
{
    public Partner returnedPartner { get; set; }
    public EditForm(Partner partner)
    {
        InitializeComponent();
        InitComboBox();
        returnedPartner = partner;
        InitControlsValues();
    }

    private void InitControlsValues()
    {
        comboBox1.SelectedItem = returnedPartner.Type;
        CompanyOfTitleForEdit_TextBox.Text = returnedPartner.CompanyName;
        Director_TextBox.Text = returnedPartner.DirectorName;
        PhoneNumber_TextBox.Text = returnedPartner.PhoneNumber;
        Rating_TextBox.Text = returnedPartner.Rating.ToString();
        DiscountValue_Label.Text = returnedPartner.Discount + "%";
        SoldProd_TextBox.Text = returnedPartner.NumOfSoldProducts.ToString();
    }

    private void button1_Click(object sender, EventArgs e) {
        using (var dbContext = new DataBaseContext()) {
            var currentPartner = dbContext.Partners.Find(returnedPartner.Id);
            currentPartner.Type = comboBox1.SelectedItem.ToString();
            dbContext.Partners.Update(currentPartner);
            dbContext.SaveChanges();
            returnedPartner = currentPartner;
        };
    }

    private void InitComboBox()
    {
        comboBox1.Items.Add("Водоснабжение");
        comboBox1.Items.Add("Видеонаблюдение");
        comboBox1.Items.Add("Пожарная охрана");
        comboBox1.Items.Add("Вентиляции");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show($"Вы уверены что хотите удалить запись о партнере {returnedPartner.CompanyName}?" +
            $"\nЭто действие предотвратить нельзя",
            "Подтвердите удаление",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) != DialogResult.Yes
        )
            return;

        MessageBox.Show("Удалено");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}
