namespace FirstKval;

internal class PartnerCard {
    public static Panel? GetPartnerCard(Partner partner) {
        new PartnerCard(partner);
        return _partnerCard;
    }

    private static Panel? _partnerCard;
    private PartnerCard(Partner partner) {
        _partnerCard = CreatePartnerCard(partner);
    }

    private Panel CreatePartnerCard(Partner partner) {
        Panel card = CreatePanel();
        Label titleLabel = CreateTitleLabel(partner.Type, partner.CompanyName);
        Label directorLabel = CreateDirectorLabel(partner.DirectorName);
        Label phoneLabel = CreatePhoneNumberLabel(partner.PhoneNumber);
        Label ratingLabel = CreateRatingLabel(partner.Rating);
        Label discountLabel = CreateDiscountLabel(partner.Discount);

        card.Controls.Add(titleLabel);
        card.Controls.Add(directorLabel);
        card.Controls.Add(phoneLabel);
        card.Controls.Add(ratingLabel);
        card.Controls.Add(discountLabel);

        return card;
    }

    private Panel CreatePanel() {
        return new Panel {
            BorderStyle = BorderStyle.FixedSingle,
            Size = new Size(475, 120),
            Margin = new Padding(15),
            BackColor = Color.FromArgb(100, 100, 100)
        };
    }

    private Label CreateTitleLabel(string type, string partnerName) {
        return new Label {
            Name = "TitleLabel",
            Text = $"{type} | {partnerName}",
            Font = new Font("Arial", 14),
            Location = new Point(10, 10),
            AutoSize = true
        };
    }

    private Label CreateDirectorLabel(string directorName) {
        return new Label {
            Name = "DirectorLabel",
            Text = directorName,
            Font = new Font("Arial", 13),
            Location = new Point(10, 35),
            AutoSize = true
        };
    }

    private Label CreatePhoneNumberLabel(string phoneNumber) {
        return new Label {
            Name = "PhoneNumberLabel",
            Text = phoneNumber,
            Font = new Font("Arial", 13),
            Location = new Point(10, 55),
            AutoSize = true
        };
    }

    private Label CreateRatingLabel(float rating) {
        return new Label {
            Name = "RatingLabel",
            Text = $"Рейтинг: {rating}",
            Font = new Font("Arial", 13),
            Location = new Point(10, 75),
            AutoSize = true
        };
    }

    private Label CreateDiscountLabel(ushort discount) {
        return new Label {
            Name = "DiscountLabel",
            Text = discount + "%",
            Font = new Font("Arial", 16),
            ForeColor = Color.Black,
            Location = new Point(400, 10),
            AutoSize = true
        };
    }
}
