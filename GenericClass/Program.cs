using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Product
    {

    }
    interface IProduct:IRepos<Product>
    {
        
    }
    class Customer
    {


    }
    interface ICustomer:IRepos<Customer>
    {
        
    }
    interface IRepos<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entitiy);
        void Delete(T entitiy);
        void Update(T entitiy);
    }
    class ProductDal : IProduct
    {
        public void Add(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomer
    {
        public void Add(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
