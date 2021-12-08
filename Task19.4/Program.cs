using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19._4
{
    class Computer
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public string AmountRAM { get; set; }
        public int Cost { get; set; }
        public int Copies { get; set; }
        public List<string> Characteristic { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer(){Code="2D293EA ", Brand="HP", ProcessorType="Intel Core i5", AmountRAM="8ГБ", Cost=64000, Copies=15, Characteristic=new List<string>(){ "1.6ГГц", "SSD 256ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="BMH-WFQ9HN", Brand="HONOR", ProcessorType="AMD Ryzen 7", AmountRAM="16ГБ", Cost=92000, Copies=4, Characteristic=new List<string>(){ "2.3ГГц", "SSD 512ГБ", "VRAM 8ГБ"}},
                new Computer(){Code="SF714-52T-78V2", Brand="Acer", ProcessorType="Intel Core i7", AmountRAM="16ГБ", Cost=123000, Copies=6, Characteristic=new List<string>(){ "1.5ГГц", "SSD 512ГБ", "VRAM 16ГБ"}},
                new Computer(){Code="TD0038057RU", Brand="Haier", ProcessorType="Intel Celeron", AmountRAM="4ГБ", Cost=23410, Copies=35, Characteristic=new List<string>(){ "1.1ГГц", "SSD 128ГБ", "VRAM встроен."}},
                new Computer(){Code="5871546 ", Brand="Apple", ProcessorType="Apple M1", AmountRAM="8ГБ", Cost=84000, Copies=20, Characteristic=new List<string>(){ "3.2ГГц", "SSD 256ГБ", "VRAM встроен."}},
                new Computer(){Code="82FG004GRU", Brand="Lenovo", ProcessorType="Intel Core i5", AmountRAM="16ГБ", Cost=103990, Copies=32, Characteristic=new List<string>(){ "2.4ГГц", "SSD 512ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="JYU4320CN", Brand="Xiaomi", ProcessorType="Intel Core i7", AmountRAM="16ГБ", Cost=65990, Copies=12, Characteristic=new List<string>(){ "1.3ГГц", "SSD 512ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="KLVD-WFE9", Brand="HUAWEI", ProcessorType="Intel Core i7", AmountRAM="16ГБ", Cost=86999, Copies=10, Characteristic=new List<string>(){ "2.8ГГц", "SSD 512ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="XPS 13 7390", Brand="DELL", ProcessorType="Intel Core i7", AmountRAM="8ГБ", Cost=89990, Copies=0, Characteristic=new List<string>(){ "1.3ГГц", "SSD 256ГБ", "VRAM встроен."}},
            };
            // вывести весь список, сгруппированный по типу процессора:

            Console.WriteLine("Список, сгруппированный по типу процессора: ");            
            Console.Write("Выберите вариант 1 или 2: ");
            string choice = Convert.ToString(Console.ReadLine());
            switch (choice)
            {
                case "1":
                    {
                        var сomputers3 = listComputer
                            .GroupBy(c => c.ProcessorType);
                        Console.WriteLine($"\nКод продукта:\t|\tМарка продукта:\t");
                        foreach (IGrouping<string, Computer> c in сomputers3)
                        {
                            Console.WriteLine($"\nТип процессора: {c.Key}");
                            foreach (var t in c)
                            {
                                Console.WriteLine($"{t.Code}\t    \t{t.Brand}\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case "2":
                    {
                        var сomputers4 = listComputer
                            .GroupBy(c => c.ProcessorType)
                            .Select(g => new
                            {
                                Brand = g.Key,
                                Count = g.Count(),
                                Computer = g.Select(c => c)
                            });
                        foreach (var group in сomputers4)
                        {
                            Console.WriteLine($"\n{group.Brand} : {group.Count}");
                            foreach (Computer p in group.Computer)
                                Console.WriteLine(p.Brand);
                            Console.WriteLine();
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }      
            }
            Console.ReadKey();
        }
    }
}
