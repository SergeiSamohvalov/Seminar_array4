// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

namespace tack_25
{
    public class Program
    {
        static void Main(string[] args)
        {
            void FillArray(int[] number)
            {
                int length = number.Length;
                int index = 0;
                while (index < length)
                {
                    number[index] = new Random().Next(1, 10);
                    index++;
                }
            }

            void Printarray(int[] mass)
            {
                int count = mass.Length;
                int index = 0;
                while (index < count)
                {
                    Console.Write($"{mass[index].ToString()} ");
                    index++;
                }
            }

            int[] array = new int[2];

            FillArray(array);

            Printarray(array);

            Console.WriteLine();

            Console.WriteLine(Math.Pow(array[0], array[1]));
        }
    }
}