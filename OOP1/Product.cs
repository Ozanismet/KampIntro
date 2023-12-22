using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Ürün
    {
        public int Id { get; set; }
        // Kategori Id
        public int CategoryId { get; set; }
        //Ürün adı
        public string ProductName { get; set; }
        // Ürün Fiyatı
        public double UnitPrice { get; set; }
        // Ürün stok adedi
        public int UnitsInStock { get; set; }


    }
}
// BU TARZ CLASSLAR DA SADECE ÜRÜNLERİN ÖZELLİKLERİ OLUR.
