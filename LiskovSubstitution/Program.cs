using System;

namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity e = new Product();
            e.Create();
            e.Update();
            e.Delete();

            e = new Category();
            e.Create();
            e.Update();//Exception
            e.Delete();//Exception

            //Con SOLID
            LiskovSubstitution.WithSolid.ICreatable c =
                new LiskovSubstitution.WithSolid.Product();
            c.Create();

            c = new LiskovSubstitution.WithSolid.Category();
            c.Create();

            Console.WriteLine("Hello World!");
        }
    }
}
