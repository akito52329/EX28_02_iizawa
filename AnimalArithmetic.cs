using System;
using System.Collections.Generic;
using System.Text;

namespace EX28
{
    class AnimalArithmetic
    {
        private float legsA;  // 動物Aの脚の数
        private float legsB;  // 動物Bの脚の数
        private float _heads = 0;
        public float heads// 全部の頭の数
        {
            get
            {
                return _heads;
            }
            set
            {
                if (_heads != value)
                {
                    _heads = value;
                    GetHeads();
                }
            }
        }

        private float _legs = 0;
        public float legs// 全部の脚の数
        {
            get
            {
                return _legs;
            }
            set
            {
                if (_legs != value)
                {
                    _legs = value;
                    GetHeads();
                }

            }
        }
    


        private float _headsA;// 動物Aの頭数（計算で求められる）
        public float headsA
        {
            get
            {
                return _headsA;
            }
        }

        private float _headsB;// 動物Aの頭数（計算で求められる）
        public float headsB// 動物Bの頭数（計算で求められる）
        {
            get
            {               
                return _headsB;
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

        void GetHeads()
        {
            _headsB = (legs - heads * legsA) / (legsB - legsA);
            _headsA = heads - _headsB;
        }

    }
}
