class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime ExpirationDate { get; set; }

    public override string ToString()
        => $"{Name};{Price:f};{ExpirationDate:yyyy-MM-dd}";
}