using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceYoutube
{
    class PersonManager
    {
        // Şu anlama geliyor burası parametre olarak ben bir ekleme yapacağım. Parametre olarak bana bir IPerson interfacein den bana bir 
        // person ver. 
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
