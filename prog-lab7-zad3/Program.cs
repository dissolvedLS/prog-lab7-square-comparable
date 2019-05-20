using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab7_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            // выбор действия
            int N = 0;
            Square[] newSquare = new Square[N];
            while (true)
            {
                Console.WriteLine("Выберите действие: 1 - добавить квадрат, 2 - сортировать, 3 - выход");
                int action = 0;
                while (action != 1 && action != 2 && action != 3)
                {
                    try
                    {
                        action = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка при вводе! Введите 1, 2 или 3.");
                        action = 0;
                    }
                }

                switch (action)
                {
                    case 1:
                        Console.WriteLine("Введите длину стороны, для создания квадрата : ");
                        double side = 0;
                        while (side == 0)
                        {
                            try
                            {
                                side = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ошибка при вводе! Попытайтесь снова.");
                                side = 0;
                            }
                        }

                        N++;
                        Console.WriteLine(N);
                        Array.Resize(ref newSquare, N);
                        newSquare[N-1] = new Square(side);

                        Console.WriteLine("Квадрат создан!");
                        Console.WriteLine("Его периметр: " + newSquare[N - 1].Perimeter());
                        Console.WriteLine("Площадь: " + newSquare[N - 1].Area());
                        Console.WriteLine("Радиус вписанной окружности: {0:f2}", newSquare[N - 1].r);
                        Console.WriteLine("Радиус описанной окружности: {0:f2}", newSquare[N - 1].R);
                        break;
                    case 2:
                        Array.Sort(newSquare);
                        Console.WriteLine("Сортировка прошла успешно!");
                        foreach (Square sqr in newSquare)
                            Console.WriteLine("Квадрат со стороной " + sqr.a);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
