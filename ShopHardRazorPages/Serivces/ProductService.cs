using ShopHardRazorPages.Models;

namespace ShopHardRazorPages.Serivces;

public class ProductService
{
    private static readonly string imageURL = "~/images/"; 
    
    private readonly List<Product> _products =
    [
        new Product
        {
            Id = 1,
            Name = "Product 1",
            Price = 10,
            Description = "Description of Product 1",
            ImageUrl = imageURL + "sampleProduct.jpeg",
            Stock = 100
        },

        new Product
        {
            Id = 2,
            Name = "Product 1",
            Price = 20,
            Description = "Description of Product 2",
            ImageUrl = imageURL + "sampleProduct.jpeg",
            Stock = 200
        }

    ];
}