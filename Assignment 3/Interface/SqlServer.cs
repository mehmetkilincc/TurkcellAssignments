using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SqlServer : BaseDatabase,IDatabase<Customer>
    {
        public SqlServer(string connectionString) : base(connectionString)
        {
            // SqlConnection nesnesi oluşturulur ve veritabanı bağlantısı yapılır.
        }
        public Customer GetById(int id)
        {
            //Kod hata vermemesi amacıyla örnek customer nesnesi oluşturuldu.
            Customer customer = new Customer(1, "Mehmet", "Kılınç", "mehmet@gmail.com");

            // Sql serverdeki müşteri bilgilerini almak için gerekli işlemler burada yapılır.
            return customer;
        }
        public void Add(Customer customer)
        {
            // Sql server veritabanına müşteri ekleme işlemi burada yapılır.
        }
    }
}
