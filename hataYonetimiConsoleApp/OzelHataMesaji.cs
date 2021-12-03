using System;
using System.Collections.Generic;
using System.Text;

namespace hataYonetimiConsoleApp
{
    public class OzelHataMesaji:Exception
    {
        public OzelHataMesaji()
        {
            Console.WriteLine("Özel Hata Mesajı");

        }
    }
}
