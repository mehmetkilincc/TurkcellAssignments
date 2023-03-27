namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Şifre Oluşturucuya Hoşgeldiniz ****");
            Console.Write("Lütfen oluşturmak istediğiniz şifreyi giriniz :");
            string password = Console.ReadLine();

            bool isPasswordLengthEnough = CheckPasswordLength(password);
            bool isContainLetter = CheckPasswordContainLetter(password);
            bool isContainNumber = CheckPasswordContainNumber(password);
            bool isContainPunctuation = CheckPasswordContainPunctiation(password);

            if (isPasswordLengthEnough)
            {
                if (isContainLetter && isContainNumber && isContainPunctuation)
                {
                    Console.WriteLine($"{password} Güçlü düzeyde bir şifredir.)");
                }
                else if (isContainLetter && isContainNumber && !isContainPunctuation)
                {
                    Console.WriteLine($"{password} Orta düzeyde bir şifredir.)");
                }
                else
                {
                    Console.WriteLine($"{password} Zayıf düzeyde bir şifredir!\n" +
                                      $"Şifrelerinizde harf,sayı ve noktalama işaretlerini kullanmanızı öneririz.");
                }
            }
            else
            {
                Console.WriteLine("Şifre en az 6 karakterden oluşmalıdır!");
            }
        }

        /// <summary>
        ///  Bu fonksiyon şifre uzunluğunun geçerliliğini kontrol eder. 
        /// </summary>
        /// <param name="password"> Karakter uzunluğunu kontrol etmek için gereklidir. </param>
        /// <returns> Karakter uzunluğu geçerli ise true değilse false deeğer dönderir. </returns>
        public static bool CheckPasswordLength(string password)
        {
            bool isValid = password.Length >= 6;
            return isValid;
        }

        /// <summary>
        /// Bu fonksiyon şifrenin harf içerme durumunu kontrol eder.
        /// </summary>
        /// <param name="password">Harf içerme kontrolünü yapmak için gereklidir.</param>
        /// <returns>Şifre harf içeriyor ise true, içermiyorsa false değer dönderir.</returns>
        public static bool CheckPasswordContainLetter(string password)
        {
            foreach (var character in password)
            {
                if (char.IsLetter(character))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Bu fonksiyon şifrenin sayı içerme durumunu kontrol eder.
        /// </summary>
        /// <param name="password">Sayı içerme kontrolünü yapmak için gereklidir.</param>
        /// <returns>Şifre sayı içeriyor ise true, içermiyorsa false değer dönderir.</returns>
        public static bool CheckPasswordContainNumber(string password)
        {
            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Bu fonksiyon şifrenin noktalama işareti içerme durumunu kontrol eder.
        /// </summary>
        /// <param name="password">Noktalama işareti içerme kontrolünü yapmak için gereklidir.</param>
        /// <returns>Şifre noktalama işareti içeriyor ise true, içermiyorsa false değer dönderir.</returns>
        public static bool CheckPasswordContainPunctiation(string password)
        {
            foreach (var character in password)
            {
                if (char.IsPunctuation(character))
                {
                    return true;
                }
            }
            return false;
        }
    }
}