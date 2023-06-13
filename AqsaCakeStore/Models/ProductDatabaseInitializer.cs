using System.Collections.Generic;
using System.Data.Entity;

namespace AqsaCakeStore.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Chocolate Cake"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Vanilla Cakes"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Fruit Cakes"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Red Velvet Cakes"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Special Occasion Cakes"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                    {
                        ProductID = 1,
                        ProductName = "Chocolate Fudge Cake",
                        Description = "Rich and indulgent chocolate cake with fudge filling and chocolate ganache frosting.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 1
                    },
                    new Product
                    {
                        ProductID = 2,
                        ProductName = "Vanilla Bean Cake",
                        Description = "Delicate and moist vanilla cake made with real vanilla beans and layered with vanilla buttercream.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 2
                    },
                    new Product
                    {
                        ProductID = 3,
                        ProductName = "Mixed Berry Cake",
                        Description = "Light and fruity cake with layers of fresh mixed berries, whipped cream, and a hint of lemon.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 3
                    },
                    new Product
                    {
                        ProductID = 4,
                        ProductName = "Red Velvet Cheesecake",
                        Description = "Decadent red velvet cake layered with creamy cheesecake filling and topped with cream cheese frosting.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 4
                    },
                    new Product
                    {
                        ProductID = 5,
                        ProductName = "Birthday Confetti Cake",
                        Description = "Fun and festive vanilla cake filled with colorful sprinkles and frosted with buttercream and more sprinkles.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 5
                    },
                    new Product
                    {
                        ProductID = 6,
                        ProductName = "Dark Chocolate Raspberry Cake",
                        Description = "Decadent dark chocolate cake layered with raspberry filling and covered in chocolate ganache.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 1
                    },
                    new Product
                    {
                        ProductID = 7,
                        ProductName = "Lemon Blueberry Cake",
                        Description = "Zesty lemon cake studded with fresh blueberries and frosted with lemon cream cheese frosting.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 2
                    },
                    new Product
                    {
                        ProductID = 8,
                        ProductName = "Pineapple Upside-Down Cake",
                        Description = "Classic cake with caramelized pineapple rings and cherries baked on top and a moist buttery cake base.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 3
                    },
                    new Product
                    {
                        ProductID = 9,
                        ProductName = "Coconut Cream Cake",
                        Description = "Fluffy coconut cake layers filled with coconut cream filling and topped with coconut flakes.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 4
                    },
                    new Product
                    {
                        ProductID = 10,
                        ProductName = "Oreo Cookies and Cream Cake",
                        Description = "Decadent chocolate cake layered with crushed Oreo cookies and cookies and cream frosting.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 5
                    },
                    new Product
                    {
                        ProductID = 11,
                        ProductName = "Classic Chocolate Cake",
                        Description = "Indulge in the rich, moist layers of our classic chocolate cake, perfect for all chocolate lovers.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 1
                    },
                    new Product
                    {
                        ProductID = 12,
                        ProductName = "Strawberry Shortcake",
                        Description = "Enjoy the combination of light sponge cake, fresh strawberries, and fluffy whipped cream in our delightful Strawberry Shortcake.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 2
                    },
                    new Product
                    {
                        ProductID = 13,
                        ProductName = "Blueberry Lemon Cake",
                        Description = "Savor the tangy and refreshing flavor of our Blueberry Lemon Cake, featuring layers of zesty lemon cake and sweet blueberry filling.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 3
                    },
                    new Product
                    {
                        ProductID = 14,
                        ProductName = "Velvet Raspberry Cake",
                        Description = "Experience the perfect harmony of rich red velvet cake and luscious raspberry filling in our Velvet Raspberry Cake.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 4
                    },
                    new Product
                    {
                        ProductID = 15,
                        ProductName = "Carrot Cream Cheese Cake",
                        Description = "Treat yourself to the delightful combination of moist carrot cake and creamy cream cheese frosting in our Carrot Cream Cheese Cake.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 5
                    },
                    new Product
                    {
                        ProductID = 16,
                        ProductName = "Cookies and Cream Delight",
                        Description = "Indulge in the heavenly flavors of cookies and cream with our Cookies and Cream Delight cake, featuring layers of chocolate cake and crushed cookies.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 1
                    },
                    new Product
                    {
                        ProductID = 17,
                        ProductName = "Luscious Lemon Cake",
                        Description = "Delight in the bright and citrusy taste of our Luscious Lemon Cake, adorned with a zesty lemon glaze.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 2
                    },
                    new Product
                    {
                        ProductID = 18,
                        ProductName = "Triple Berry Bliss",
                        Description = "Experience a burst of berry goodness with our Triple Berry Bliss cake, featuring layers of vanilla cake and a mix of fresh berries.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 3
                    },
                    new Product
                    {
                        ProductID = 19,
                        ProductName = "Mint Chocolate Delight",
                        Description = "Indulge in the refreshing combination of mint and chocolate with our Mint Chocolate Delight cake, featuring layers of chocolate cake and mint-infused filling.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 4
                    },
                    new Product
                    {
                        ProductID = 20,
                        ProductName = "Coconut Dream Cake",
                        Description = "Transport yourself to a tropical paradise with our Coconut Dream Cake, featuring layers of moist coconut cake and creamy coconut frosting.",
                        ImagePath = "logo.jpg",
                        UnitPrice = 122.95,
                        CategoryID = 5
                    }
            };

            return products;
        }
    }
}