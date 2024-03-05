using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework19
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Random rnd = new Random();

            List<Computer> computers = new List<Computer>()
            {
                new Computer(){CodeName = "Model1", ProcType = "Proc1", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 50) },
                new Computer(){CodeName = "Model2", ProcType = "Proc2", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 60) },
                new Computer(){CodeName = "Model3", ProcType = "Proc1", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 70) },
                new Computer(){CodeName = "Model4", ProcType = "Proc2", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 60) },
                new Computer(){CodeName = "Model5", ProcType = "Proc3", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 20) },
                new Computer(){CodeName = "Model6", ProcType = "Proc3", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 80) },
                new Computer(){CodeName = "Model7", ProcType = "Proc4", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 70) },
                new Computer(){CodeName = "Model8", ProcType = "Proc5", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 100) },
                new Computer(){CodeName = "Model9", ProcType = "Proc4", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 80) },
                new Computer(){CodeName = "Model10", ProcType = "Proc5", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 60) },
                new Computer(){CodeName = "Model11", ProcType = "Proc6", Freq = rnd.Next(15, 150), OperMem = rnd.Next(4, 16), HardWare = rnd.Next(6, 32), VidMem = rnd.Next(50, 150), Price = rnd.Next(50000, 120000), Amount = rnd.Next(1, 20) },
            };

            Console.WriteLine("Введите тип процессора");
            string proc = Console.ReadLine ();
            Console.WriteLine();
            List<Computer> computers1 = computers.Where(p=>p.ProcType == proc).ToList ();
            Print(computers1);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            

            Console.WriteLine("Введите объём ОЗУ");
            double oper = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            List<Computer> computers2 = computers.Where(p => p.OperMem >= oper).ToList();
            Print(computers2);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();

            Console.WriteLine("Список, отсортированный по стоимости:");
            List<Computer> computers3 = computers.OrderBy(p => p.Price).ToList();
            Print(computers3);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Список, сгруппированный по типу процессора:");
            Console.WriteLine();
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(p => p.ProcType).ToList();
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer computer in gr)
                {
                    Console.WriteLine($"{computer.CodeName}, {computer.ProcType}, {computer.Freq}, {computer.OperMem}, {computer.HardWare}, {computer.VidMem}, {computer.Price}, {computer.Amount}");
                }
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.WriteLine();

            Computer computer4 = computers.OrderByDescending(p => p.Price).FirstOrDefault();
            Console.WriteLine($"Самый дорогой компьютер: {computer4.CodeName}, {computer4.ProcType}, {computer4.Freq}, {computer4.OperMem}, {computer4.HardWare}, {computer4.VidMem}, {computer4.Price}, {computer4.Amount}");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.WriteLine();

            Computer computer5 = computers.OrderBy(p => p.Price).FirstOrDefault();
            Console.WriteLine($"Самый дешевый компьютер: {computer5.CodeName}, {computer5.ProcType}, {computer5.Freq}, {computer5.OperMem}, {computer5.HardWare}, {computer5.VidMem}, {computer5.Price}, {computer5.Amount}");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.WriteLine();

            bool istrue = computers.Any(p => p.Amount >= 30);
            Console.WriteLine("Есть ли компьютер в количестве не менее 30 шт.?");
            Console.WriteLine("Ответ: {0}", istrue);
            Console.ReadKey();
            Console.WriteLine();

        }
        static void Print(List<Computer> computers)
        {
            foreach(Computer computer in computers)
            {
                Console.WriteLine($"{computer.CodeName}, {computer.ProcType}, {computer.Freq}, {computer.OperMem}, {computer.HardWare}, {computer.VidMem}, {computer.Price}, {computer.Amount}");
                Console.WriteLine();
            }
        }
    }
}
