using System;

namespace SingleResponsability
{
    internal class ProductsService
    {
        public void Create(Product product)
        {
            //Lógica para crear los productos

            //Registramos la actividad
            Activity activity = new Activity()
            {
                Message = $"Producto {product.Id} Creado",
                CreatedDate = System.DateTime.Now,
                Module = nameof(Create)
            };

            WriteLog(activity);
        }

        private void WriteLog(Activity activity)
        {
            //Registramos la actividad sucedida
            Console.WriteLine($"{activity.Message}-{activity.Module}-{activity.CreatedDate}");
        }
    }
}

namespace SingleResponsability.WithSOLID
{
    internal class ProductsService
    {
        private readonly ILog Logger;
        public ProductsService(ILog logger)
        {
            Logger = logger;
        }

        public void Create(Product product)
        {
            //Lógica para crear los productos

            //Registramos la actividad
            Activity activity = new Activity()
            {
                Message = $"Producto {product.Id} Creado",
                CreatedDate = System.DateTime.Now,
                Module = nameof(Create)
            };
            Logger.Write(activity);
        }
    }

    public interface ILog
    {
        void Write(Activity activity);
    }

    public class LogService: ILog
    {
        public void Write(Activity activity)
        {
            //Registramos la actividad sucedida
            Console.WriteLine($"{activity.Message}-{activity.Module}-{activity.CreatedDate}");
        }
    }
}