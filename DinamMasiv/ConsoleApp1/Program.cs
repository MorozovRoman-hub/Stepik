using System;


namespace Masivdinam

{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            var array = new DynamicArray(6);

            var count = array.GetCount(); // Получить количество элементов 
            Console.WriteLine(count); // выводит 0

            //var item = array.Get(3); 

            var index = array.Find(7); // Получить индекс элемента, значение которого равно 7

            Console.WriteLine(index); // выводит -1

            index = array.Find(1); // Получить индекс элемента, равный 1
            Console.WriteLine(index); // выводит -1

            var printedArray = array.Print(); // Распечатать массив
            Console.WriteLine(printedArray); // выводит пустую строку
            }
            catch { }
            Console.ReadKey();
        }

        private static int Result(int countOne, int countOneMax)
        {
            if (countOne > countOneMax)
            {
                countOneMax = countOne;

            }

            return countOneMax;
        }
    
    }
}
