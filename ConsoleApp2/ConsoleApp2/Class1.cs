using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Firm
    {
        private string Mark { get; set; }
        private string Nomer { get; set; }
        private string Surname { get; set; }
        private int Capacity { get; set; }
        private bool Inrace { get; set; }
        private string Timeout { get; set; }
        private int Raceduring { get; set; }

        public Firm(string mark, string nomer, string surname, int capacity, bool inrace, string timeout, int raceduring)
        {
            Mark = mark;
            Nomer = nomer;
            Surname = surname;
            Capacity = capacity;
            Inrace = inrace;
            Timeout = timeout;
            Raceduring = raceduring;

        }
        public Firm(string mark, string nomer, int capacity)
        {
            Mark = mark;
            Nomer = nomer;
            Capacity = capacity;
        }
        public Firm()
        {

        }
        public void Prinsss()
        {
            Console.WriteLine("Марка авто: " + Mark);
            Console.WriteLine("Номер авто: " + Nomer);
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Емнисть машини: " + Capacity);
            Console.WriteLine("Чи в дорози: " + Inrace);
            Console.WriteLine("Дата виизду: " + Timeout);
            Console.WriteLine("Скильки днив в дорози: " + Raceduring);
            Console.WriteLine();
        }
        public void PrintFreeAuto(Firm[] arr1)
        {
            Console.WriteLine("Вильни для перевезень: ");
            foreach (var item in arr1)
            {
                if (item.Inrace == false)
                {
                    Console.WriteLine(item.Mark + ", ");

                }
            }
            Console.WriteLine("======================================");
        }
        public void PrintAutoInrace(Firm[] arr1)
        {
            Console.WriteLine("Знаходяться в перевезенях: ");
            foreach (var item in arr1)
            {
                if (item.Inrace == true)
                {
                    Console.WriteLine(item.Mark + ", ");

                }
            }
            Console.WriteLine("======================================");
        }
        public void PrintFreeAuto(Firm[] arr1, int kg)
        {
            Console.WriteLine("Не в перевезенях и достатьня грузо пидйомнисть: ");
            foreach (var item in arr1)
            {
                if (item.Inrace == false)
                {
                    if (item.Capacity >= kg)
                    {
                        Console.WriteLine(item.Mark + ", ");

                    }
                }
            }
            Console.WriteLine("======================================");
        }
        public void InFileAll(List<Firm> Firms)
        {
            for (int i = 0; i < Firms.Count; i++)
            {
                using (StreamWriter sw = File.CreateText($@"C:\Users\Shrek\Desktop\asdasd\as{i}.txt"))
                {
                    sw.WriteLine(Firms[i].Mark);
                    sw.WriteLine(Firms[i].Nomer);
                    sw.WriteLine(Firms[i].Surname);
                    sw.WriteLine(Firms[i].Capacity);
                    sw.WriteLine(Firms[i].Inrace);
                    sw.WriteLine(Firms[i].Timeout);
                    sw.WriteLine(Firms[i].Raceduring);
                }

            }
        }
        public void OutOfFileAll(List<Firm> Firms, string[] arr2)
        {
            int fCount = Directory.GetFiles("C:\\Users\\Shrek\\Desktop\\asdasd", "*", SearchOption.AllDirectories).Length;

            Console.WriteLine("Дани з файлу :");
            Console.WriteLine();

            for (int i = 0; i < fCount; i++)
            {
                if (File.Exists($@"C:\Users\Shrek\Desktop\asdasd\as{i}.txt"))
                {
                    arr2 = File.ReadAllLines($@"C:\Users\Shrek\Desktop\asdasd\as{i}.txt");
                    Firms.Add(new Firm());
                    Firms[i].Mark = arr2[0];
                    Console.WriteLine($"Марка: {Firms[i].Mark}");
                    Firms[i].Nomer = arr2[1];
                    Console.WriteLine($"Номер: {Firms[i].Nomer}");
                    Firms[i].Surname = arr2[2];
                    Console.WriteLine($"Фамилия: {Firms[i].Surname}");
                    Firms[i].Capacity = Convert.ToInt32(arr2[3]);
                    Console.WriteLine($"Грузопидимность: {Firms[i].Capacity}");
                    Firms[i].Inrace = Convert.ToBoolean(arr2[4]);
                    Console.WriteLine($"В рейси: {Firms[i].Inrace}");
                    Firms[i].Timeout = arr2[5];
                    Console.WriteLine($"Дата виизду: {Firms[i].Timeout}");
                    Firms[i].Raceduring = Convert.ToInt32(arr2[6]);
                    Console.WriteLine($"Час в рейси: {Firms[i].Raceduring}");
                    Console.WriteLine("===================================");
                }
            }
            Console.WriteLine();
        }

}
}
