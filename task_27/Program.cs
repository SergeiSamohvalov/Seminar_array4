// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

namespace tack_27
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
                    number[index] = new Random().Next(0, 10);
                    index++;
                }
            }

            void PrintArray(int[] mass)
            {
                int count = mass.Length;
                int index = 0;
                while (index < count)
                {
                    Console.Write(mass[index].ToString());
                    index++;
                }
            }

            void PrintSum(int[] coll)
            {
                int sum = coll.Sum();
                Console.Write(sum);
            }

            int[] array = new int[5];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintSum(array);
        }
    }

}
