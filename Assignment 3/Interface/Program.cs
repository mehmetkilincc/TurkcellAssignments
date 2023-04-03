// See https://aka.ms/new-console-template for more information
using Interface;

//Sql server veritabanı üzerinde gerçekleştirilecek işlemler
SqlServer sqlServer = new SqlServer("sql server bağlantı dizesi");

Customer customer = new Customer(1, "Mehmet" ,"Kılınç", "mehmet@gmail.com");
sqlServer.Add(customer);
sqlServer.GetById(customer.Id);

//Oracle veritabanı üzerinde gerçekleştirilecek işlemler
Oracle oracle = new Oracle("oracle server bağlantı dizesi");

Customer customer1 = new Customer(2, "Esra", "Dal", "esra@gmail.com");
oracle.Add(customer1);
oracle.GetById(customer1.Id);

