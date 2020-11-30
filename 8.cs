using System;

namespace ConsoleApp26

{
    internal class Product
    {
        public float PriceDollar { get; set; }
        public int CountGoods { get; set; }
        public float DollarRate { get; set; }
        public float NDS { get; set; }

        public float CountNDS()
        {
            return ((GetPriceInRub() * NDS) / 100);
        }

        public float PriceWithOutNDS()
        {
            return (GetPriceInRub() - CountNDS());
        }

        public float GetPriceInRub()
        {
            return PriceDollar * DollarRate;
        }

        public float NDSWithValueAdded()
        {
            return ((PriceWithOutNDS() * 18) / 100);
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Product product = new Product();

                Console.Write("Введите цену в долларах с НДС:");
                String priceString = Console.ReadLine();
                if (priceString != null) product.PriceDollar = float.Parse(priceString);

                Console.Write("Введите количества товара:");
                String countString = Console.ReadLine();
                if (countString != null) product.CountGoods = Int32.Parse(countString);

                Console.Write("Введите текущий курс доллара:");
                String rateString = Console.ReadLine();
                if (rateString != null) product.DollarRate = float.Parse(rateString);

                Console.Write("Введите НДС:");
                String ndsString = Console.ReadLine();
                if (ndsString != null) product.NDS = float.Parse(ndsString);
                if (product.PriceDollar > 100) throw new Exception();

                Console.WriteLine("\r\nСчет фактура:");
                Console.WriteLine("Цена на товар без НДС -\t\t\t\t{0} р.", product.PriceWithOutNDS());
                Console.WriteLine("Сумма НДС -\t\t\t\t\t{0} р.", product.CountNDS());
                Console.WriteLine("Сумма заказа в рублях с НДС -\t\t\t{0} р.", product.GetPriceInRub());
                Console.WriteLine("Налог на добавленную стоимость -\t\t{0} р.", product.NDSWithValueAdded());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ошибка!");
            }
            Console.WriteLine("Для выхода из программы нажмите Enter.");
            Console.ReadLine();
        }
    }
}
