using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            return  pigs * 4 + cows * 4 + chickens * 2;
        }
    }
}
