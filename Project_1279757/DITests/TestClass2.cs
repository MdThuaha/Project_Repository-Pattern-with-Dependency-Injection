using Project_1279757.Factories;
using Project_1279757.Models;
using Project_1279757.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279757.DITests
{
    internal class TestClass2
    {
        public void Run(IRepositoryFactory factory)
        {
            IRepository<Customer> repoC = factory.CreateRepository<Customer>();
            repoC.AddRange(new Customer[] {
                new Customer{ Id=1, Name="Thuaha",ContactNo="01784523635",Adress="Mirpur"},
                new Customer{ Id=2, Name="Rakib",ContactNo="01725638741",Adress="Muhammadpur"},
                new Customer{Id = 3, Name = "Tanim", ContactNo = "01868759391", Adress = "Dhanmondi"},
                new Customer{Id = 4, Name = "Rabin", ContactNo = "01358965715", Adress = "Badda"},
                new Customer{Id = 5, Name = "Shaker", ContactNo = "01815893214", Adress = "Gulshan"}
            });
            //GetAll
            Console.WriteLine("GetAll");
            repoC.GetAll().ToList()
                .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name},ContactNo:{c.ContactNo},Adress:{c.Adress}"));
            //Get by id
            Console.WriteLine("Get");
            var cus = repoC.Get(3);
            Console.WriteLine($"Id: {cus.Id}, Name: {cus.Name},ContactNo:{cus.ContactNo},Adress:{cus.Adress}");
            //Update
            Console.WriteLine("Update");
            cus.Name = "Selim";
            repoC.Update(cus);
            repoC.GetAll().ToList()
               .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name},ContactNo:{c.ContactNo},Adress:{c.Adress}"));
            //Delete
            Console.WriteLine("Delete");
            repoC.Delete(3);
            repoC.GetAll().ToList()
              .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name},ContactNo:{c.ContactNo},Adress:{c.Adress}"));
            Console.WriteLine("******************");
            IRepository<Item> repoI = factory.CreateRepository<Item>();
            repoI.AddRange(new Item[]
            {
                new Item{ Id=1, Name="Gap Casual", Price=790.00M, Stock=30, CustomerId=1},
                 new Item{ Id=2, Name="Levisl", Price=1790.00M, Stock=30, CustomerId=2},
                  new Item{ Id=3, Name="Prince Hat", Price=190.00M, Stock=30, CustomerId=4},
                   new Item{ Id=4, Name="Pioneer Glove", Price=790.00M, Stock=30, CustomerId=5}
            });
            //GetAll
            Console.WriteLine("GetAll");
            repoI.GetAll().ToList()
                .ForEach(i => Console.WriteLine($"Id:{i.Id}, Name: {i.Name}, Price: {i.Price}, Stock: {i.Stock}"));
            //Get
            Console.WriteLine("Get");
            var item = repoI.Get(2);
            Console.WriteLine($"Id:{item.Id}, Name: {item.Name}, Price: {item.Price}, Stock: {item.Stock}");
            //Update
            Console.WriteLine("Update");
            item.Price = 1900;
            repoI.Update(item);
            repoI.GetAll().ToList()
               .ForEach(i => Console.WriteLine($"Id:{i.Id}, Name: {i.Name}, Price: {i.Price}, Stock: {i.Stock}"));
            //Delete
            Console.WriteLine("Delete");
            repoI.Delete(2);
            repoI.GetAll().ToList()
               .ForEach(i => Console.WriteLine($"Id:{i.Id}, Name: {i.Name}, Price: {i.Price}, Stock: {i.Stock}"));
        }
    }
}
