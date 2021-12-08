using System;

namespace EX28
{
    class Constructor
    {
        public static int InputLegs(string message)
        {
            Console.WriteLine(message);
            return InputCheck(message);
        }

        public static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static int InputCheck(string message)
        {
            int i;
            while (true)
            {

                try
                {
                    i = int.Parse(Console.ReadLine());
                    if(i % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("入力エラーです。もう一回やり直してください");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("数字でもう一回入力してください。");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("範囲があってませんでもう一回入力してください。");
                }

                Console.WriteLine(message);
            }
            return i;
        }   
        

        public static bool AnswerCheck(float a, float b)
        {
            return a - Math.Floor(a) == 0 && a >= 0 && b - Math.Floor(b) == 0 && b >= 0;
        }
    }
}
