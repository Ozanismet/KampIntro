using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1,FirstName="Ozan",LastName="Alyörük",City="İstanbul" };
            Customer customer2 = new Customer (2,"Derin","Demiroğ","Ankara");
            Console.WriteLine(customer1.Id+" "+ customer1.FirstName+" "+customer1.LastName);
            Console.WriteLine(customer2.FirstName);
            
     

        }
    }


    class Customer
    {
        public Customer()
        {
            // customer1 türünden yazmamız için bunu yapıyoruz çünkü alt kısım da constructor ın farklı versiyonu yazılması için farklı 
            // bir tür oluşturduk. Bu yüzden customer2 o halde yazabiliyoruz ama customer1 farklı yazıldığı için hata vericek onun için 
            // bu alanı oluşturduk. 
        }
        // default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
