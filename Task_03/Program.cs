/*Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.*/

namespace Task_03
{
    public class Program
    {
        public static void Main(string [] arg){
            Random rand = new Random();
            int num = rand.Next(-10,10);
            int size_01 =9;
            int size_02 = size_01 / 2;
            int [] array = new int [size_01];
            int [] newarray = new int[size_02];
            for (int i =0;i< size_01;i++)
            {
                array [i] = rand.Next(-10,11);
            }
             System.Console.Write("Массив ");
             foreach (int item in array)
            {

                System.Console.Write(item+ "  ");
            }
            System.Console.Write("Измененный массив");
            for (int i =0;i< size_02;i++)
            {
                int index = size_01-1-i;
                newarray [i] = array[i]*array[index];
            }
            foreach (int item in newarray)
            {

                System.Console.Write(item+ "  ");
            }
            Console.WriteLine();
            if (size_01%2 != 0)
            {
                Console.WriteLine(array [size_02]+" не имеет пары");
            }
        }
        
        }
  }