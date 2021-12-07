using System;
using System.Collections.Generic;
using System.Text;

namespace EX28
{
    class AnimalArithmetic
    {
        private float legsA;  // 動物Aの脚の数
        private float legsB;  // 動物Bの脚の数
        public float heads;  // 全部の頭の数
        public float legs;// 全部の脚の数

        public float HeadsA
        {
            get
            {
                 return heads - HeadsB;
            }
        }

        public float HeadsB// 動物Bの頭数（計算で求められる）
        {
            get
            {               
                return (legs - heads * legsA) / (legsB - legsA);
            }
        }



        public AnimalArithmetic(float a, float b)
        {
            legsA = a;
            legsB = b;
        }

        public AnimalArithmetic(int a, int b, int h, int l)
        {
            legsA = a;
            legsB = b;
            heads = h;
            legs = l;
        }
        public void SetHeadsLegs(float h, float l)
        {
            heads = h;
            legs = l;
        }
    }
}
