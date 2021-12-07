using System;

namespace EX28
{
    class ex28Main
    {
        static void Main(string[] args)
        {
            AnimalArithmetic animalArithmetic = new AnimalArithmetic(
                  Constructor.Input("動物Aの脚の数："),
                  Constructor.Input("動物Bの脚の数："));

            animalArithmetic.SetHeadsLegs(
                Constructor.Input("動物AとBの合計の頭の数："),
                  Constructor.Input("動物AとBの合計の脚の数："));

            Console.WriteLine($"動物Aの数{animalArithmetic.headsA},動物Bの数{animalArithmetic.headsB}");
        }
    }
}