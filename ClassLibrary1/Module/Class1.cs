using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1.Module
{
    public class Class1
    {
        public void myMetod1()
        {
            try
            {
                string message = Console.ReadLine();
                if (message.Length > 6)
                {
                    throw new Exception("Длина строки больше 6 символов");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
