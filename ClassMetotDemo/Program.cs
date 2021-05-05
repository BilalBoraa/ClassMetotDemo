using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0001;
            customer1.Name = "Bilal Bora";
            customer1.CreditPoint = ("8/10");
            customer1.City = "Sakarya";
            customer1.PhoneNumber = 0954560000;
            
            Customer customer2 = new Customer();
            customer2.Id = 0002;
            customer2.Name = "Ahmet";
            customer2.CreditPoint = ("6/10");
            customer2.City = "Adana";
            customer2.PhoneNumber = 0953560000;

            Customer customer3 = new Customer();
            customer3.Id = 0003;
            customer3.Name = "Yusuf";
            customer3.CreditPoint = ("9/10");
            customer3.City = "İzmir";
            customer3.PhoneNumber = 0953260000;

            Customer customer4 = new Customer();
            customer4.Id = 0004;
            customer4.Name = "Fatih";
            customer4.CreditPoint = ("4/10");
            customer4.City = "Mersin";
            customer4.PhoneNumber = 0952560000;


            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            Console.WriteLine("********** Customer List *************");
            foreach (var i in customers)
            {
            Console.WriteLine("\nCustomer Id = {0}\nCustomer Name = {1}\nCustomer CreditPoint = {2}\nCustmer City = {3}\nCustomer PhoneNumber = {4}",i.Id,i.Name,i.CreditPoint,i.City,i.PhoneNumber);
            }


            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("----------------");
            customerManager.Add(customer1);
            Console.WriteLine("-------------");
            customerManager.Delete(customer3);
            Console.WriteLine("--------------");
            customerManager.Uptade(customer4);



           






        }
    }
}
