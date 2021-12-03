using System;

namespace hataYonetimiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("bir sayı giriniz");
                int enter = Convert.ToInt32(Console.ReadLine());
                if (enter==10)
                {
                    throw new OzelHataMesaji();
                }
            }
            catch (OzelHataMesaji fx)
            {
                Console.WriteLine("Hatalı format özel hata mesajı girdi");
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı format");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lütfen sayı giriniz...{0}",ex);
            }
        }
    }
}
