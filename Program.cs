using System;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 0;    //Количество попыток бросков трех кубиков

            int sum = 0;

            while (sum < 15)
            {
                sum = 0;
                Random diece = new Random();
                int rol1 = diece.Next(1, 7);
                int rol2 = diece.Next(1, 7);
                int rol3 = diece.Next(1, 7);
                sum = rol1 + rol2 + rol3;
                num++;
                /*
                Console.WriteLine(" На брошенном кубике выпало число \n" +
                    $"  1-e:    {rol1}\n" +
                    $"  2-e:    {rol2}\n" +
                    $"  3-e:    {rol3}\n");
                */

                if ( (rol1 == rol2) || (rol1 == rol3) || (rol2 == rol3) )
                {
                    if ((rol1 == rol2) && (rol1 == rol3) && (rol2 == rol3))
                    {
                        if (sum >= 9)
                        {
                            sum += 6;
                            Console.WriteLine(ShowRoll.PrintShowRoll(rol1, rol2, rol3) + "Выпало ТРИ!!! одинаковых числа!!! \n" + $"Итого у вас {sum} очков на {num} попытке");
                        }
                    } 
                    else
                    {
                        if (sum >= 13)
                        {
                            sum += 2;
                            Console.WriteLine(ShowRoll.PrintShowRoll(rol1, rol2, rol3) + "Выпало Два!!! одинаковых числа!!! \n" + $"Итого у вас {sum} очков на {num} попытке");
                        }
                    }
                }
                else
                
                        if (rol1 != rol2 && rol1 != rol3 && rol2 != rol3)
                        {
                            if (sum >= 15)
                            {
                                Console.WriteLine(ShowRoll.PrintShowRoll(rol1, rol2, rol3) + "Все числа разные! \n" + $"И всё же у вас {sum} очков на {num} попытке");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==================================================");
                            Console.WriteLine("Error");
                            Console.WriteLine($"На попытке : {num}");
                            Console.WriteLine($"Выбито очков : {sum}");
                            ShowRoll.PrintShowRoll(rol1, rol2, rol3);
                            Console.WriteLine("==================================================");
                        }               
            }
        }
    }
}

