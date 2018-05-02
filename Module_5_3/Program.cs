using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Module;



/// <summary>
/// 3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
/// </summary>

namespace Module_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 myClass = new Class2();

            myClass.myMetod2();
        }
    }
}
