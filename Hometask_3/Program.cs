/*Задайте массив из вещественных чисел с
ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива.*/
namespace Hometask_03
{
    public class Program
    {
        public static void Main(string [] arg){
            
            double[] array = { -1.5, 2.8, -3.2, 4.7, 5.9 };
           
            double max=0;
            double min=0;
             System.Console.Write("Массив ");
             foreach (int item in array)
            {

                System.Console.Write(item+ "  ");
            }
            for (int i =0;i< 5;i++)
            {
                if (array [i]>max)
                {
                max = array[i];
                }  
                if (array[i]<min)
                {
                    min = array[i];
                }
                
               }   
               double diff = max-min;
            System.Console.Write($"=> {min} and {max} diff {diff}");
            }
            
        }
        
        }
  