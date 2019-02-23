using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_тайм_оф_дэй
{
    class Program
    {
                /*Дано время в тиках (1 тик = 100 наносекунд = 10-7 секунд) от начала нашей эры.
        Выведите время данного дня в формате hh:mm:ss.t (час, минута, секунда, тик, если количество тиков нулевое, то выводить точку не нужно).

        Начальные данные: строка, в которой записано одно число.
        Вывод результата: строка формата hh:mm:ss.t.*/
        static void Main(string[] args)
        {
            DateTime dt = new DateTime (long.Parse(Console.ReadLine()));
            Console.WriteLine(dt.TimeOfDay);

        }
    }
}
