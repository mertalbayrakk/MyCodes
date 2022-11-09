using ClassMethodDemo;

Customer customer1 = new Customer();
customer1.Name = "Mert";
customer1.Surname = "Albayrak";
customer1.Id = 11111;
customer1.Tc = 123456789;

Customer customer2 = new Customer();
customer2.Name = "Mustafa";
customer2.Surname = "Kurt";
customer2.Id = 22222;
customer2.Tc = 987654321;

Customer customer3 = new Customer();
customer3.Name = "Mahmut";
customer3.Surname = "Yiğit";
customer3.Id = 33333;
customer3.Tc = 963852741;

CustomerManager customerManager = new CustomerManager();

customerManager.Listele(customer1, customer2, customer3);

customerManager.Ekle(customer2);

customerManager.Sil(customer3);