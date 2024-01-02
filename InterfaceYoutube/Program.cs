using System;

namespace InterfaceYoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { Id = 1, FirstName="Ozan", LastName="Alyörük", Address="150" };
            Student student = new Student { Id = 2, FirstName = "Engin", LastName = "Çelik", Departmant = "2B" };

            personManager.Add(student);
            personManager.Add(customer);

            Console.ReadLine();

            // İnterface sınıfın da şablon oluştururuz ve işlem yapmayız sadece bağlı olan sınıfları kullandırtırız.
            // PersonManager sınıfın da parametre tanımlarız yani toplanan sınıflar ınterface sınıfın da olduğu için o bilgileri oraya ekleriz.
            // Bunu eklerken de program satırına gelip oluşturduğumuz personManager adı ile hangi isim ile özellik eklediysek onu ekleriz.
        }
    }
}
