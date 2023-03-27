namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Encapsulation (Kapsülleme), sınıf yapımız içerisinde yer alan private erişim seviyesindeki değişkenlerin ve
             * metot yapılarının dışarıdan güvenli bir şekilde erişilmesini sağlamak amacıyla ya da
             * güvenli bir şekilde muhafaza etmek için kullanılan önemli bir nesne yönelimli programlama özelliğidir.
             */

            Console.WriteLine("************** Bank **************");

            BankAccount mybankAccount = new BankAccount();
            mybankAccount.AccountNumber = 3243;
            mybankAccount.AccountHolder = "Mehmet Kılınç";

            
            mybankAccount.DepositMoney(1000);

            mybankAccount.WithdrawMoney(500);
        }
    }
    public class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private decimal accountbalance;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public decimal AccountBalance
        {
            get { return accountbalance; }
            private set { accountbalance = value; }
        }

        //"DepositMoney" ve "WithdrawMoney" methodları, BankAccount sınıfının dışında kullanılabilen yöntemlerdir.
        // Ancak, bu yöntemler sadece sınıfın içindeki "accountbalance" özelliği üzerinde işlem yaparlar ve
        // bu özellik sadece BankAccount sınıfının içinde erişilebilir olduğu için Encapsulation uygulanmış olur

        public void DepositMoney(decimal amount)
        {
            accountbalance += amount;
            Console.WriteLine($"{accountNumber} nolu hesaba {amount}TL yatırma işlemi gerçekleşmiştir. Güncel bakiyeniz: {accountbalance}");
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > accountbalance)
                Console.WriteLine("Yetersiz bakiye!");
            else
            {
                accountbalance -= amount;
                Console.WriteLine($"{amount}TL Para çekme işlemi gerçekleşmiştir. Güncel bakiyeniniz: {accountbalance}");
            }
        }
    }
}