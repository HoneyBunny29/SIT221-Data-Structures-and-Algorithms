﻿namespace BoxOfCoins
{
    class TestGenerator
    {
        static public int Count()
        {
            return 29;
        }
        public static int Generate(int k, out int[] arg)
        {
            int result = -1; arg = null;
            switch (k)
            {
                case 0: arg = new[] { 7, 2 }; result = 5; break;
                case 1: arg = new[] { 2, 7, 3 }; result = -2; break;
                case 2: arg = new[] { 1000, 1000, 1000, 1000, 1000 }; result = 1000; break;
                case 3: arg = new[] { 823, 912, 345, 100000, 867, 222, 991, 3, 40000 }; result = -58111; break;
                case 4: arg = new[] { 23, 35, 12, 100000, 99234, 86123, 3245 }; result = -83644; break;
                case 5: arg = new[] { 23, 35, 12, 100000, 99234, 86123, 3245, 1 }; result = 83645; break;
                case 6: arg = new[] { 7, 7, 7, 7, 7, 7, 80, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 }; result = -66; break;
                case 7: arg = new[] { 7, 7, 7, 7, 7, 7, 7, 80, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 }; result = 73; break;
                case 8: arg = new[] { 91, 56, 23, 45, 87, 65, 45, 45, 78, 23, 20, 41, 17, 54, 51, 51, 94, 62, 74, 42, 76, 76 }; result = 96; break;
                case 9: arg = new[] { 92834, 95461, 15911, 56189, 6369, 80545, 31811, 51263, 30076, 68867, 36905, 32499, 59799, 334, 82991, 46636, 98741, 66601 }; result = 42958; break;
                case 10: arg = new[] { 129 }; result = 129; break;
                case 11: arg = new[] { 35463, 88121, 4362, 94457, 86235, 83680, 72686, 6003, 93069, 2015, 10436, 2139, 93162, 30380, 19067, 76335, 78941, 48620, 55887, 15679 }; result = 101879; break;
                case 12: arg = new[] { 19335, 97643, 11468, 86267, 79718, 59584, 12129, 52642, 86575, 62307, 11545, 52658, 72377, 39986, 74850, 1992, 86928 }; result = 1846; break;
                case 13: arg = new[] { 91883, 97793, 54567, 64714, 98624 }; result = 82567; break;
                case 14: arg = new[] { 98473, 41866, 71129, 65936, 42626, 9194, 46718, 96921, 45613, 47677, 8763, 54634, 47259, 71448, 9918, 22666, 32711, 21692, 40207, 2017, 23040, 86083, 77809, 15472, 30718, 39085, 87911, 54827, 41686, 28354, 37203, 6548, 74184, 3043, 43961, 95189, 1238, 22002, 93507, 63546, 32527, 42778, 31614 }; result = -14953; break;
                case 15: arg = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }; result = 25; break;
                case 16: arg = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }; result = 0; break;
                case 17: arg = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11, 11, 11, 11, 111, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 112, 312, 312, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 231, 31, 312 }; result = 316; break;
                case 18: arg = new[] { 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45, 1234, 1233, 12, 312, 32, 23, 434, 12, 312, 45 }; result = 1995; break;
                case 19: arg = new[] { 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }; result = 1; break;
                case 20: arg = new[] { 9, 100, 1, 8 }; result = 98; break;
                case 21: arg = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 66, 5, 4, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 6, 5, 4, 5, 6, 3, 4, 4, 5, 6, 3, 4, 5, 6, 3, 4, 5, 6, 3, 4, 5, 6, 3, 4, 5, 6 }; result = 68; break;
                case 22: arg = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 1, 2, 3, 4, 65, 67, 2, 3, 4, 7, 2, 3, 4, 6, 6, 7, 2, 3, 4, 7, 78, 8, 82, 2, 3, 4, 7, 2, 2, 34, 4, 6, 7, 3, 2 }; result = 128; break;
                case 23: arg = new[] { 100, 10, 10 }; result = 100; break;
                case 24: arg = new[] { 1 }; result = 1; break;
                case 25: arg = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 4, 3, 5, 4, 6, 7, 5, 6, 10, 2, 5, 4, 3, 4, 5, 6, 7, 9, 10 }; result = 28; break;
                case 26: arg = new[] { 6, 4, 3, 5, 8, 8 }; result = 2; break;
                case 27: arg = new[] { 1, 5, 20, 2, 1 }; result = -13; break;
                case 28: arg = new[] { 1, 2, 3, 4, 5, 6, 6, 7, 8, 767, 765, 111, 76576, 5, 64, 654, 64, 7, 7657, 76575, 64, 65, 6454, 64, 654, 65464, 7, 5435, 65, 746, 7, 546, 7, 654, 7, 5435, 547, 6, 6, 7, 6547, 7654, 6, 754, 54353, 65, 7, 8 }; result = 118231; break;
            }
            return result;

        }
    }
}