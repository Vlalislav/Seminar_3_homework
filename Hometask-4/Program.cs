/*Задача 4**(не обязательно): Дано натуральное
число в диапазоне от 1 до 100 000. Создайте массив,
состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе
массива, младший – на последнем. Размер массива
должен быть равен количеству цифр.
425 => [4 2 5]
8741 => [8 7 4 1]
4 => [4]
*/
namespace Hometask_02
{
    public class Program
    {
        public static void Main(string [] arg)
        {
            Random rand = new Random();
            int num = rand.Next(1,100000);
            Console.WriteLine(num);
            double size = Math.Log10(Convert.ToDouble(num));
            size = Math.Ceiling(size);
            int size2=Convert.ToInt32(size);
           
            Console.WriteLine(size);
            int [] array = new int [Convert.ToInt32(size)];
            for (int i = size2-1; i>= 0; i--)
            {
                array [i] = num%10;
                num = num /10;
            }
             System.Console.Write("Массив ");
             foreach (int item in array)
            {

                System.Console.Write(item+ "  ");
            }
            
            }
            
        }
        
        }
  