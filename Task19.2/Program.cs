using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19._2
{
    class Computer
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public int AmountRAM { get; set; }
        public int Cost { get; set; }
        public int Copies { get; set; }
        public List<string> Characteristic { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  частотой  работы  процессора,  
             * объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. 
             * Создать список, содержащий 6-10 записей с различным набором значений характеристик.
             */
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer(){Code="2D293EA ", Brand="HP", ProcessorType="Intel Core i5", AmountRAM=8, Cost=64000, Copies=15, Characteristic=new List<string>(){ "1.6ГГц", "SSD 256ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="BMH-WFQ9HN", Brand="HONOR", ProcessorType="AMD Ryzen 7", AmountRAM=16, Cost=92000, Copies=4, Characteristic=new List<string>(){ "2.3ГГц", "SSD 512ГБ", "VRAM 8ГБ"}},
                new Computer(){Code="SF714-52T-78V2", Brand="Acer", ProcessorType="Intel Core i7", AmountRAM=16, Cost=123000, Copies=6, Characteristic=new List<string>(){ "1.5ГГц", "SSD 512ГБ", "VRAM 16ГБ"}},
                new Computer(){Code="TD0038057RU", Brand="Haier", ProcessorType="Intel Celeron", AmountRAM=4, Cost=23410, Copies=35, Characteristic=new List<string>(){ "1.1ГГц", "SSD 128ГБ", "VRAM встроен."}},
                new Computer(){Code="5871546 ", Brand="Apple", ProcessorType="Apple M1", AmountRAM=8, Cost=84000, Copies=20, Characteristic=new List<string>(){ "3.2ГГц", "SSD 256ГБ", "VRAM встроен."}},
                new Computer(){Code="82FG004GRU", Brand="Lenovo", ProcessorType="Intel Core i5", AmountRAM=16, Cost=103990, Copies=32, Characteristic=new List<string>(){ "2.4ГГц", "SSD 512ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="JYU4320CN", Brand="Xiaomi", ProcessorType="Intel Core i7", AmountRAM=16, Cost=65990, Copies=12, Characteristic=new List<string>(){ "1.3ГГц", "SSD 512ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="KLVD-WFE9", Brand="HUAWEI", ProcessorType="Intel Core i7", AmountRAM=16, Cost=86999, Copies=10, Characteristic=new List<string>(){ "2.8ГГц", "SSD 512ГБ", "VRAM 2ГБ"}},
                new Computer(){Code="XPS 13 7390", Brand="DELL", ProcessorType="Intel Core i7", AmountRAM=16, Cost=89990, Copies=0, Characteristic=new List<string>(){ "1.3ГГц", "SSD 256ГБ", "VRAM встроен."}},
            };
            //  Определить:
            // - все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя:
            Console.WriteLine("Введите объём ОЗУ: ");
            int ask2 = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Computer> сomputers = from c in listComputer
                                              where c.AmountRAM >= ask2
                                              orderby c.Cost descending
                                              select c;
            foreach (Computer c in сomputers)
            {
                Console.WriteLine($"Код продукта: {c.Code}  \tМарка продукта: {c.Brand} \tОбъём ОЗУ: {c.AmountRAM}ГБ \tСтоимость: {c.Cost} руб.");
            }
            Console.ReadKey();
        }
    }
}
