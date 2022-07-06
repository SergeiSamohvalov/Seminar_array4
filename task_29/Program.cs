// Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10)
// элементов (значение элементов от 1 до 40)  и выводит на экран массив квадратов этих чисел.

namespace tack_29
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
                    number[index] = new Random().Next(1, 41);
                    index++;
                }
            }

            void PrintArray(int[] mass)
            {
                int count = mass.Length;
                int index = 0;
                while (index < count)
                {
                    Console.Write($"{mass[index].ToString()} ");
                    index++;
                }
            }

            void PrintArraySquare(int[] mass)
            {
                int count = mass.Length;
                int index = 0;
                while (index < count)
                {
                    Console.Write($"{Math.Pow(mass[index], 2).ToString()} "); ;
                    index++;
                }
            }

            int[] array = new int[new Random().Next(5, 11)];
           
            FillArray(array);
            PrintArray(array);
            
            Console.WriteLine();
            PrintArraySquare(array);

        }
    }
}
