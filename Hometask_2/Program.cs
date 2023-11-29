/*Задайте массив на 10 целых чисел.
Напишите программу, которая определяет
количество чётных чисел в массиве.*/

namespace Hometask_02
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
                if (array [i]%2 == 0)
                {
                times = times +1;
                }   
               }   
            System.Console.Write($"=> {times}");
            }
            
        }
        
        }
  
