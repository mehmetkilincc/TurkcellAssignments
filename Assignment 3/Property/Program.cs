namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Property, nesnelerin özelliklerini (property) tanımlayan ve bu özelliklere erişimi kontrol eden bir yapıdır.
            //Bir property, bir sınıfın veya bir nesnenin özelliğini temsil eder ve genellikle get ve set yöntemleriyle erişilir.
            //Get yöntemi, özelliğin değerini almak için kullanılırken, set yöntemi, özelliğin değerini ayarlamak için kullanılır.

            //Yani property yapıları özünde nesne içerisindeki bir field'in dışarıya kontrollü açılmasını
            //ve dışarıdan kontrollü bir şekilde değer almasını sağlayan yapılardır.

            Person person1 = new Person();//Nesne Ürettik

            person1.Name = "Mehmet"; //SET
            person1.Surname = "Kılınç"; //SET

            Console.WriteLine(person1.Name + " " + person1.Surname);//GET
        }
    }

    class Person
    {
        #region Property

        //Full propertynin sade ve güncel versiyonudur.
        public string Name { get; set; }

        #endregion

        #region FullProperty
        private string surname;
        public string Surname
        {
            get
            {
                //Propertynin değeri çağrıldığında get bloğu tetiklenir ve değer return edilir.
                return surname;
            }
            set
            {
                //PropertyE değer atama işlemi gerçekleştiğinde set bloğu tetiklenir ve değer atama işlemi gerçekleşir.
                surname = value;
            }
        }
        #endregion

    }
}