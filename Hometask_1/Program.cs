/*Задача 1: Задайте одномерный массив из 10 целых
чисел от 1 до 100. Найдите количество элементов
массива, значения которых лежат в отрезке [20,90]. */
namespace Hometask_01
{
    public class Program
    {
        public static void Main(string [] arg){
            Random rand = new Random();
            int num = rand.Next(1,100);
            int size =10;
            int times = 0;
            int [] array = new int [size];
            for (int i =0;i< size;i++)
            {
                array [i] = rand.Next(1,100);
            }
             System.Console.Write("Массив ");
             foreach (int item in array)
            {

                System.Console.Write(item+ "  ");
            }
            for (int i =0;i< size;i++)
            {
                if (array [i] == 20)
                {
                times = times +1;
                }   
                if (array [i] == 90)
                {
                times = times +1;
                }   
            }
            System.Console.Write("=>" +times);
        }
        
        }
  }