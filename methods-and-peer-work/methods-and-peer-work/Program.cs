namespace methods_and_peer_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxwell Sigrest
             * IGME 201 - interactive Des & Alg Prob Sol III
             * Dat: 11/17/2024 */

            //declaration
            int maxFavNum; 
            int partnerFavNum;
            int addValue;
            int subValue;

            //initialize
            maxFavNum = 10;
            partnerFavNum = 8;

            static int Subtract(int int3, int int4)
            {
                int value2 = int3 - int4;
                return value2;
            }

            //start of actual program
            Console.WriteLine("Max's favorite number is: " + maxFavNum);
            Console.WriteLine("Partners favorite number is: " + partnerFavNum);

            addValue = Add(maxFavNum, partnerFavNum);
            Console.WriteLine("When we add out favorite numbers together we get: " + addValue);

            subValue = Subtract(maxFavNum, partnerFavNum);
            Console.WriteLine("When we subtract our favorite numbers together we get: " + subValue);
        }

        static int Add(int int1, int int2)
        {
            int value = int1 + int2;
            return value;
        }
    }
}
