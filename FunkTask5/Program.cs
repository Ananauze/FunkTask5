using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[] numbers = new int[] { 1, 2, 5, 7, 9, 5, 3, 2 };

            PrintArray(numbers);
            ShuffleArray(numbers);

            Console.ReadLine();
        }

        static void PrintArray(int[] array) 
        {
            Console.WriteLine("Для начаал выводим созданный массив: ");
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void ShuffleArray(int[] array) 
        {
            Random random = new Random();
            int randomIndex;
            int randomNumber;

            Console.WriteLine("\nТеперь измененный массив внавалку:");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                randomIndex = random.Next(i);       
                randomNumber = array[randomIndex]; 
                array[randomIndex] = array[i];      
                array[i] = randomNumber;           
                Console.Write(array[i] + " ");
            }
        }
    }
}
