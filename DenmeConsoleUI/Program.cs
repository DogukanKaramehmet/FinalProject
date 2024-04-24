// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;

ProductTest();
//CategoryTest();

Console.ReadLine();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProducDal());

    var result = productManager.GetProductDetails();

    if (result.Success== true)
    {
            foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName+" / "+ product.CategoryName+" / "+product.UnitInStock);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var Category in categoryManager.GetAll())
    {
        Console.WriteLine(Category.CategoryName);
    }
}