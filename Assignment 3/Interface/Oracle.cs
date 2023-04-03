using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Oracle :BaseDatabase, IDatabase<Customer>
    {
        public Oracle(string connectionString) : base(connectionString)
        {
            // OracleConnection nesnesi oluşturulur ve veritabanı bağlantısı yapılır
        }
        public Customer GetById(int id)
        {
            Customer customer = new Customer(2, "Ahmet", "Karaca", "ahmet@gmail.com");

            // Oracle veritabanındaki müşteri bilgilerini almak için gerekli işlemler burada yapılır.

            return customer;
        }
        public void Add(Customer customer)
        {
            // Oracle veritabanına müşteri ekleme işlemleri burada yapılır.
        }
    }
}
