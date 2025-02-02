namespace FirstKval;

internal class Partner {
    public Guid Id { get; set; }
    public required string Type { get; set; }
    public required string CompanyName { get; set; }
    public required string DirectorName { get; set; }
    public required string PhoneNumber { get; set; }
    public required float Rating { get; set; } = 0.0F;
    public required short Discount { get; set; } = 0;
    public uint NumOfSoldProducts { get; set; } = 0;
}
