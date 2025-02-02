namespace FirstKval;

public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();
        GetPartners();
    }

    private void GetPartners() {
        Panel? partnerCard;
        var partnersList = GetPartnersList();

        foreach (var partner in partnersList) {
            partnerCard = PartnerCard.GetPartnerCard(partner);
            partnerCard.Click += PartnerCard_Click;
            partnersLayoutPanel.Controls.Add(partnerCard);
        }
    }

    private void PartnerCard_Click(object? sender, EventArgs e) {
        Panel panel = sender as Panel;

        foreach (var label in panel.Controls) {
            ReplaceText(label as Label);
        }

        GUID_TextBox.Text = Guid.NewGuid().ToString();
    }

    private void ReplaceText(Label label) {
        switch (label.Name){
            case "TitleLabel":
                Text = label.Text;
                TypeOfTitleForEdit_TextBox.Text = Text.Split(" |")[0];
                CompanyOfTitleForEdit_TextBox.Text = Text.Split("| ")[1];
                break;

            case "DirectorLabel":
                Director_TextBox.Text = label.Text;
                break;

            case "PhoneNumberLabel":
                PhoneNumber_TextBox.Text = label.Text;
                break;

            case "RatingLabel":
                Rating_TextBox.Text = label.Text.Split("Рейтинг: ")[1];
                break;

            case "DiscountLabel":
                DiscountValue_Label.Text = label.Text;
                break;

            case "NumOfSoldProducts":
                SoldProd_TextBox.Text = label.Text;
                break;
        }
    }

    private List<Partner> GetPartnersList() {
        return InitPartnerList();
    }

    private List<Partner> InitPartnerList() {
        using (var dbContext = new DataBaseContext()) {
            if (!dbContext.Partners.Any())
                return null;

            return dbContext.Partners.ToList();
        }
    }
}
