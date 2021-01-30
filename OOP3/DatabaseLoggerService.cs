using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }

}



// FilebaseLoggerService DatabaseLoggerService gibi buraya yazıldı ve ampulden Move type to FileLoggerService seçilerek ayrı dosyaya taşındı. 
