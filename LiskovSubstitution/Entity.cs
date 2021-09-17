using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Entity
    {
        //Virtual para que quien herede la clase Entity lo pueda sobrescribir
        public virtual void Create()
        {
            //Código de la creación
        }

        public virtual void Update()
        {
            //Código de la actualización
        }

        public virtual void Delete()
        {
            //Código de la eliminación
        }
    }

    public class Product : Entity
    {
        public override void Create()
        {
            //Aquí le ponemos la lógica propia de ese objeto
        }

        public override void Update()
        {
            //Aquí le ponemos la lógica propia de ese objeto
        }

        public override void Delete()
        {
            //Aquí le ponemos la lógica propia de ese objeto
        }
    }

    //Solo expondrá la funcional de Create
    public class Category : Entity
    {
        public override void Create()
        {
            //Aquí le ponemos la lógica propia de ese objeto
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}

namespace LiskovSubstitution.WithSolid
{
    public interface ICreatable
    {
        void Create();
    }

    public interface IUpdateable
    {
        void Update();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface ICud : ICreatable, IUpdateable, IDeletable
    {

    }

    public class Product : ICreatable, IDeletable, IUpdateable
    {
        public void Create()
        {
            //...
        }

        public void Delete()
        {
            //...
        }

        public void Update()
        {
            //...
        }
    }

    public class Category : ICreatable
    {
        public void Create()
        {
            //...
        }
    }
}