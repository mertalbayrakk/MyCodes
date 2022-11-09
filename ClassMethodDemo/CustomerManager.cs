using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {   

        //Params ile Listeleme.
        public void Listele(params Customer[] customers)
        {

            //foreach sayesinde herbir müşteriyi listelettim.

            foreach (Customer customer in customers)
                Console.WriteLine("Ad Soyadı:" + customer.Name + " " + customer.Surname + "\n" + "Id:" + customer.Id + "\n" + "Tc:" + customer.Tc + "\n" + "-------------");

        }


        public void Ekle(Customer customer)
        {

            Console.WriteLine(customer.Name + " " + customer.Surname + ": " + "Tebrikler. Müşteri Başarıyla Eklendi!");



        }


       public void Sil(Customer customer)
        {

           Console.WriteLine(customer.Name + " " + customer.Surname + ": " + "Dikkat! Müşteri Silindi!");



        }



        // Params olmadan listeleme.
        public void Listelettir(Customer[] customers)
        {

            Console.WriteLine("-------------");
            foreach (Customer customer in customers)
                Console.WriteLine("Ad Soyadı:" + customer.Name + " " + customer.Surname + "\n" + "Id:" + customer.Id + "\n" + "Tc:" + customer.Tc + "\n" + "-------------");


        }


    }
}
