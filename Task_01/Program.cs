/*Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.*/

using System.Collections.ObjectModel;
using System.Formats.Asn1;

namespace Task_01
{
    public class Program
    {
        public static void Main(string [] arg){
            Random rand = new Random();
            int num = rand.Next(-5,6);
            
            //int [] array = {-4,-5,4,9,2};

            int size =10;
            int [] array = new int [size];
            for (int i =0;i< size;i++)
            {
                array [i] = rand.Next(-10,11);
            }
            bool flag = IsNumInArray(array,num);
            string result = flag ? "yes" : "no";
            foreach (int item in array)
            {

                System.Console.Write(item+ "  ");
            }
            System.Console.Write(" => " + num);
            System.Console.Write(" => " + result);

        }
        public static bool IsNumInArray(int [] array, int num){
            foreach(var item in array)
            {
                if (item == num)
            {
                return true;
            }
            }
            return false;
        }
    }
}