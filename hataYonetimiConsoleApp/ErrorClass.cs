using System;
using System.Collections.Generic;
using System.Text;

namespace hataYonetimiConsoleApp
{
   public class ErrorClass:Exception
    {
        public ErrorClass()
        {
            Console.WriteLine("Girdiğiniz Değer 1-10 arasında olmalıdır!");
        }
    }
}
