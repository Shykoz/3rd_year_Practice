using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace Labs
{

    internal class Program
    {

        static void Main(string[] args)
        {
            var Firms = new List<Firm>();
            Firm visivatel = new Firm();

            //Firm firm1 = new Firm("Alfa Romeo", "UAS81SS", 2400);
            //Firm firm2 = new Firm("Toyota", "UAS81SS", "Шевченко", 2700, true, "10.09.2022", 10);

            //Firm firm3 = new Firm("Audi", "UAS81SS", "Коваленко", 2200, false, "", 0);
            //Firm firm4 = new Firm("Bentley", "UAS81SS", "Ткаченко", 2100, false, "", 0);

            //Firm firm5 = new Firm("Buick", "UAS81SS", "Ковалчук", 2650, true, "5.09.2022", 15);
            //Firm firm6 = new Firm("Cadillac", "UAS81SS", "Шевчук", 2250, false, "", 0);

            //Firm firm7 = new Firm("Chevrolet", "UAS81SS", "Полушчук", 2400, true, "2.08.2022", 12);
            //Firm firm8 = new Firm("Fiat", "UAS81SS", "Олїнук", 2125, true, "20.09.2022", 1);

            //Firm firm9 = new Firm("Ford", "UAS81SS", "Лусенко", 2650, false, "", 0);
            //Firm firm10 = new Firm("Dodge", "UAS81SS", "Марченко", 2550, true, "7.09.2022", 13);
            string[] strr = { };
            Console.WriteLine("Дани з файлу");


            Firm[] arr = {};
            arr.Append(visivatel);
            visivatel.PrintFreeAuto(arr);
            visivatel.PrintAutoInrace(arr);
            visivatel.PrintFreeAuto(arr, 2500);
            visivatel.OutOfFileAll(Firms, strr);
            foreach (var item in arr)
            {
                Firms.Add(item);
            }
            //visivatel.InFileAll(Firms);

            //Console.WriteLine("Веддить 1 якщо ви бажаете вивести список всих авто(и дани про них) :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num == 1)
            //{

            //    foreach (var item in arr)
            //    {

            //        item.Prinsss();

            //    }

            //}


        }
    }
}