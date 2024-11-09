using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podschet_Ballov
{
    public class Program
    {
        public static int Proverka(int max, int min)
        {
            int x;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Введи значение от {min} до {max}");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (MaxMin(min, max, x))
                    { 
                        break; 
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректное значение");
                }
            }
            return x;
        }
        public static bool MaxMin(int min, int max, int mark)
        {
            if (mark < min || mark > max) 
            {
                Console.WriteLine($"Недопустимое значение от {min} до {max}");
                return false;
            }
            return true;
        }

        public static void Vvod (int a,int b, int c, int sum)
        {
            
           
            sum = a+b+c;

            Console.WriteLine($"Сумма баллов = {sum}");

            if (sum > -1 && sum < 16)
            {
                Console.WriteLine("Оценка 2 (неудовретварительно)");
            }

            if (sum > 15 && sum < 32)
            {
                Console.WriteLine("Оценка 3 (удовретварительно)");
            }

            if (sum > 31 && sum < 56)
            {
                Console.WriteLine("Оценка 4 (хорошо)");
            }

            if (sum > 55 && sum < 81)
            {
                Console.WriteLine("Оценка 5 (отлично)");
            }
        }
        static void Main(string[] args)
        {
            int a, b, c, sum=0;

            Console.WriteLine("Введи балл за задание модуля 1 «Разработка, администрирование и защита баз данных» максимальна оценка = 22");
            a = Proverka(22,0);

            Console.WriteLine("Введи балл за задание модуля 2 «Разработка модулей программного обеспечения для компьютерных систем» максимальна оценка = 38");
            b = Proverka(38, 0);

            Console.WriteLine("Введи балл за задание модуля 3 «Сопровождение и обслуживание программного обеспечения компьютерных систем» максимальна оценка = 20");
            c = Proverka(20, 0);

            Vvod(a,b,c,sum);       
            Console.ReadLine();
        }
    }
}
