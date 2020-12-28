using System;
using System.Threading;
using System.Threading.Tasks;

namespace Gigi
{
    class Program
    {
        static int a = 10, b = 10;
        static bool isAlive = true, progr = false; //проверка на живость
        static void Main(string[] args)
        {
            {
                MissionImpossible();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.ForegroundColor = ConsoleColor.Green;
                for (int k = 0; k < 30; k++)
                {
                    Thread.Sleep(100);
                    Console.Write("|..|");
                }
                Console.WriteLine("Нажмите пробел, чтобы продолжить");
                for (int j = 0; j < 100000; j++)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        progr = true; break;
                    }
                }
                if (progr)
                {
                Reboot: //возрождение
                    a = 10; b = 10;
                    Console.Clear(); //очистить консоль
                    int x, y, i, points = 0, CountFruit = 10, CountEnemies = 15;  //коорды, счетчик, очки и количество фруктов и врагов
                    char Hero = '╬', frame = '#', fruit = '*', enemy = 'X'; //иконки
                    int[,] frfr = new int[3, CountFruit];  //масив фруктов
                    int[,] enem = new int[3, CountEnemies]; //массив врагов

                    //рамка
                    drawFrame(frame);

                    x = Console.WindowWidth / 2; //центр экрана
                    y = Console.WindowHeight / 2;
                    Console.SetCursorPosition(x, y); Console.Write(Hero); //челик
                    enem = enemies(50, enemy); //отрисовка врагов
                    frfr = fruits(CountFruit, fruit); //отрисовка фруктов
                    met(1000);
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(50, 0); Console.Write("Очков: " + points);
                        //мувмент
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.A && isAlive)
                        {
                            Console.SetCursorPosition(x, y); Console.Write(" ");
                            x--;
                            Console.SetCursorPosition(x, y); Console.Write(Hero);
                        }
                        if (key.Key == ConsoleKey.D && isAlive)
                        {
                            Console.SetCursorPosition(x, y); Console.Write(" ");
                            x++;
                            Console.SetCursorPosition(x, y); Console.Write(Hero);
                        }
                        if (key.Key == ConsoleKey.W && isAlive)
                        {
                            Console.SetCursorPosition(x, y); Console.Write(" ");
                            y--;
                            Console.SetCursorPosition(x, y); Console.Write(Hero);
                        }
                        if (key.Key == ConsoleKey.S && isAlive)
                        {
                            Console.SetCursorPosition(x, y); Console.Write(" ");
                            y++;
                            Console.SetCursorPosition(x, y); Console.Write(Hero);
                        }
                        if (x == Console.WindowWidth - 1 || x == 0 || y == 1 || y == Console.WindowHeight - 1) //пересечение рамки
                        {
                            isAlive = false;
                        }
                        if (!isAlive) //смерть
                        {
                            Console.Clear();
                            Console.WriteLine("Вы умерли, набрав " + points + " очков \n Нажмите Enter, чтобы воскреснуть");
                            if (key.Key == ConsoleKey.Enter)
                            {
                                isAlive = true; goto Reboot;
                            }
                        }
                        if (points == 10) //победа
                        {
                            Console.Clear();
                            Console.WriteLine("Вы победили \n Нажмите Enter, чтобы начать заново");
                            if (key.Key == ConsoleKey.Enter)
                            {
                                isAlive = true; goto Reboot;
                            }
                        }
                        if (Console.CursorLeft == a && Console.CursorTop == b) //движущийся Х
                        {
                            isAlive = false;
                        }
                        if (Console.CursorLeft == 10 && Console.CursorTop == 9) //0
                        {
                            points++;
                        }
                        for (i = 0; i < CountFruit; i++) //набор фруктов
                        {
                            if (Console.CursorLeft == frfr[0, i] + 1 && Console.CursorTop == frfr[1, i] && frfr[2, i] == 0)
                            {
                                points++;
                                frfr[2, i] = 1;
                            }
                        }
                        for (i = 0; i < CountFruit; i++) //смерть от Х
                        {
                            if (Console.CursorLeft == enem[0, i] + 1 && Console.CursorTop == enem[1, i])
                            {
                                isAlive = false;
                            }
                        }
                    }
                }
            }
        }
        static async void MissionImpossible()
        {
            await Task.Run(() =>
            {
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(587, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(554, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(523, 1200);
                Thread.Sleep(150);
                Console.Beep(466, 150);
                Console.Beep(523, 150);
            });
        }
        static void drawFrame(char fra) //метод отрисовки рамки
        {
            int widht = Console.WindowWidth;
            int height = Console.WindowHeight - 1;
            Console.SetCursorPosition(0, 1);
            for (int i = 1; i <= widht; i++)
            {
                Console.Write(fra);
            }
            for (int i = 1; i < height; i++)
            {
                Console.WriteLine(fra);
                Console.SetCursorPosition(widht - 1, i);
                Console.WriteLine(fra);
            }
            for (int i = 1; i <= widht; i++)
            {
                Console.Write(fra);
            }
        }
        static public int[,] fruits(int count, char otobr) //создание фруктов
        {
            int[,] fruits = new int[3, count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                fruits[0, i] = rand.Next(2, 80);
                fruits[1, i] = rand.Next(2, 20);
                fruits[2, i] = 0;
                Console.SetCursorPosition(fruits[0, i], fruits[1, i]); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(otobr);
            }
            return fruits;
        }
        static public int[,] enemies(int count, char otobr) //создание врагов
        {
            int[,] enemies = new int[3, count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                enemies[0, i] = rand.Next(2, 80);
                enemies[1, i] = rand.Next(2, 20);
                enemies[2, i] = 0;
                Console.SetCursorPosition(enemies[0, i], enemies[1, i]); Console.ForegroundColor = ConsoleColor.Red; Console.Write(otobr);
            }
            return enemies;
        }
        static async void met(int time) //движущийся икс
        {
            Console.SetCursorPosition(10, 9); Console.Write('0');
            while (true)
            {
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                a++;
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                b--;
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                b--;
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                a--;
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                a--;
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                b++;
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                b++;
                Console.SetCursorPosition(a, b); Console.Write('X');
                await Task.Delay(time);
                Console.SetCursorPosition(a, b); Console.Write(' ');
                a++;
            }
        }
    }

}