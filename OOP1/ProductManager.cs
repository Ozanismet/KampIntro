using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // Bu MANAGER KISMINI GÖRDÜĞÜMÜZ DE İÇERİSİN DE OPERASYONLAR OLDUĞUNU ANLAMAMIZ LAZIM. BU OPERASYONLAR (EKLEME, SİLME,LİSTELEME) GİBİ
    class ProductManager
    {
        public void Add(Product product)      // Ekleme 
        {
            Console.WriteLine(product.ProductName+" eklendi.");
           
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi.");
        }
    }
}
