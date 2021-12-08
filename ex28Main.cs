using System;

namespace EX28
{
    class ex28Main
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AnimalArithmetic animalArithmetic = new AnimalArithmetic(
                      Constructor.InputLegs("動物Aの脚の数："),
                      Constructor.InputLegs("動物Bの脚の数："));

                animalArithmetic.SetHeadsLegs(
                    Constructor.Input("動物AとBの合計の頭の数："),
                      Constructor.Input("動物AとBの合計の脚の数："));

                if(Constructor.AnswerCheck(animalArithmetic.headsA,animalArithmetic.headsB))
                {
                    Console.WriteLine($"動物Aの数{animalArithmetic.headsA},動物Bの数{animalArithmetic.headsB}");
                    break;
                }
                else
                {
                    Console.WriteLine($"入力が間違っています。やり直してください。");
                }
            }
        }
    }
}