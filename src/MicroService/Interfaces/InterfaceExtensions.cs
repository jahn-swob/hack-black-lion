namespace MicroService.Interfaces
{
    public static class InterfaceExtensions
    {
        public static TResult Convert<TResult>(this IProduct source)
            where TResult : class, IProduct, new()
        {
            return new TResult
            {
                Sku = source.Sku,
                PrimaryFamilyId = source.PrimaryFamilyId,
                PrimaryCategoryId = source.PrimaryCategoryId,
                RegularPrice = source.RegularPrice,
                CurrentPrice = source.CurrentPrice,
                Rank = source.Rank,
                Name = source.Name,
                Description = source.Description,
                ProductUrl = source.ProductUrl,
                ImageUrl = source.ImageUrl,
                Rating = source.Rating
            };
        }
    }
}
