namespace FederatedExampleService.Interfaces
{
    public interface IProduct
    {
        int Sku { get; set; }

        int PrimaryFamilyId { get; set; }

        int PrimaryCategoryId { get; set; }

        int CurrentPrice { get; set; }

        int RegularPrice { get; set; }

        decimal Rank { get; set; }

        decimal Rating { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        string ProductUrl { get; set; }

        string ImageUrl { get; set; }
    }
}
