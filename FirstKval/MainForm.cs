using System.Text.RegularExpressions;

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

    EditForm editForm;
    private void PartnerCard_Click(object? sender, EventArgs e) {
        Panel panel = sender as Panel;
        Guid id = Guid.NewGuid();

        foreach (Control control in panel.Controls) {
            if (control.Name != "Id_Label")
                continue;
            id = Guid.Parse((control as Label).Text);
        }

        Partner currentPartner = _partners.FirstOrDefault(partner => partner.Id == id);
        editForm = new EditForm(currentPartner);
        editForm.ShowDialog();

        Partner partner = editForm.returnedPartner;
        TypeOfTitleForEdit_TextBox.Text = partner.Type;

        UpdateCards(panel, partner);
        InitPartnerList();
    }

    private void EditForm_FormClosed(object? sender, FormClosedEventArgs e) {
        var returnedPartner = editForm.returnedPartner;

        TypeOfTitleForEdit_TextBox.Text = returnedPartner.Type;
    }

    private void UpdateCards(Panel panel, Partner partner) {
        foreach (Control control in panel.Controls) {
            Label label = control as Label;
            if (label.Name == "TitleLabel") {
                label.Text = $"{partner.Type} | {partner.DirectorName}";
                break;
            }
        }
    }

    private void ReplaceText(Label label) {
        switch (label.Name) {
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

    private bool IsDigits(string text) {
        return !new Regex("/d").IsMatch(text);
    }

    private List<Partner>? GetPartnersList() {
        InitPartnerList();
        return _partners;
    }

    private List<Partner> _partners;
    private void InitPartnerList() {
        using (var dbContext = new DataBaseContext()) {
            if (!dbContext.Partners.Any())
                return;

            _partners = dbContext.Partners.ToList();
        }
    }

    private void SoldProd_TextBox_KeyPress(object sender, KeyPressEventArgs e) {
        if (IsDigits(SoldProd_TextBox.Text)) {
            try {
                DiscountValue_Label.Text = DiscountCalculate.GetDiscount(uint.Parse(SoldProd_TextBox.Text)).ToString() + "%";
            }
            catch {
                DiscountValue_Label.Text = "0%";
            }
        }
        else
            DiscountValue_Label.Text = "0%";
    }
}
