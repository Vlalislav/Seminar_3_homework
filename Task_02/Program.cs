/*Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.*/

namespace Task_01
{
    public class Program
    {
        public static void Main(string [] arg){
            Random rand = new Random();
            int num = rand.Next(-10,10);
            int size =10;
            int [] array = new int [size];
            for (int i =0;i< size;i++)
            {
                array [i] = rand.Next(-10,11);
            }
             System.Console.Write("Массив ");
             foreach (int item in array)
            {

                System.Console.Write(item+ "  ");
            }
            System.Console.Write("Измененный массив");
            for (int i =0;i< size;i++)
            {
                array [i] = array[i]*(-1);
            }
            foreach (int item in array)
            {

                System.Console.Write(item+ "  ");
            }
        }
        
        }
  }
