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
        Control control = new();

        var label = panel.Controls.Find("TitleLabel", true).FirstOrDefault() as Label;
        if (label != null)
            ReplaceText(label);
    }

    private void ReplaceText(Label label) {
        TypeOfTitleForEdit_TextBox.Text = label.Text.Split(" |")[0];
        CompanyOfTitleForEdit_TextBox.Text = label.Text.Split("| ")[1];
    }

    private List<Partner> GetPartnersList() {
        return InitPartnerList();
    }

    private List<Partner> InitPartnerList() {
        return new List<Partner> {
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
        };
    }
}
