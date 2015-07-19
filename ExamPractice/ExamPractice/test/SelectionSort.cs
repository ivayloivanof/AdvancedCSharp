namespace Test
{
    using System;

    public class SelectionSort
    {
        public static void Main()
        {
            var array = new int[13] { 100, 50, 20, 40, 48, 51, 62, 10, 60, 80, 70, 90, 30 };

            Console.WriteLine("The Array Before Selection Sort is: ");
            PrintArray(array);
            
            for (var j = 0; j < array.Length - 1; j++)
            {
                var minNumber = j;

                for (var k = j + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minNumber])
                    {
                        minNumber = k;
                    }
                }
                
                var tmp = array[minNumber];
                array[minNumber] = array[j];
                array[j] = tmp;
            }

            Console.WriteLine("The Array After Selection Sort is: ");
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
