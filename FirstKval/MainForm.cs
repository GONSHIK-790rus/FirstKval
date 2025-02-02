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
        return [
            new() {
                Type = "Водоснабжение",
                CompanyName = "Теодора",
                DirectorName = "Пилюгин Евгений Николаевич",
                PhoneNumber = "88005553535",
                Rating = 9.7F,
                Discount = 25
            },

            new() {
                Type = "Видеонаблюдение",
                CompanyName = "Союз",
                DirectorName = "Пилюгин Егор Евгеньевич",
                PhoneNumber = "89776665544",
                Rating = 9.9F,
                Discount = 13
            },

            new() {
                Type = "Пожарная охрана",
                CompanyName = "Стройзащита",
                DirectorName = "Пилюгина Людмила Александровна",
                PhoneNumber = "89165553322",
                Rating = 0.2F,
                Discount = 5
            },

            new() {
                Type = "Электрика",
                CompanyName = "ИП Пилюгин",
                DirectorName = "Пилюгин Евгений Николаевич",
                PhoneNumber = "88005553535",
                Rating = 9.5F,
                Discount = 15
            },

            new() {
                Type = "Вентиляции",
                CompanyName = "ИП Шатских",
                DirectorName = "Шатских Дмитрий Геннадьевич",
                PhoneNumber = "88009996633",
                Rating = 9.2F,
                Discount = 7
            }
        ];
    }
}
