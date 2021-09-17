using DependencyInversionAbstractions;

namespace DependencyInversion
{
    public class ProductService
    {
        readonly ILogger Logger;
        public ProductService(ILogger logger)
        {
            Logger = logger;
        }

        public void Create(Product product)
        {
            //...

            Logger.Write(new Activity()
            {
                Message = "Producto agregado",
                Module = nameof(Create),
                CreatedDate = System.DateTime.Now
            });
        }
    }
}
