using System;
using System.Collections;

namespace BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray();
            Console.ReadKey();
        }


        public static void BitArray()
        {

            // Creates and initializes several BitArrays.
            System.Collections.BitArray myBA1 = new System.Collections.BitArray(5);

            System.Collections.BitArray myBA2 = new System.Collections.BitArray(5, false);

            byte[] myBytes = new byte[1] { 1 };
            System.Collections.BitArray myBA3 = new System.Collections.BitArray(myBytes);

            bool[] myBools = new bool[5] { true, false, true, true, false };
            System.Collections.BitArray myBA4 = new System.Collections.BitArray(new byte[1] { 2 });

            int[] myInts = new int[5] { 6, 7, 8, 9, 10 };
            byte[] a = new byte[] { 8 };
            byte a1 = 8;
            var s = a1 | a1;

            System.Collections.BitArray myBA5 = new System.Collections.BitArray(myInts);

            // Displays the properties and values of the BitArrays.
            Console.WriteLine("myBA1");
            Console.WriteLine("   Count:    {0}", myBA1.Count);
            Console.WriteLine("   Length:   {0}", myBA1.Length);
            Console.WriteLine("   Values:");
           // PrintValues(myBA3.And(myBA4), 8);

            PrintValues(myBA3.Xor(myBA4), 8);




            //Console.WriteLine("myBA2");
            //Console.WriteLine("   Count:    {0}", myBA2.Count);
            //Console.WriteLine("   Length:   {0}", myBA2.Length);
            //Console.WriteLine("   Values:");
            //PrintValues(myBA2, 8);

            //Console.WriteLine("myBA3");
            //Console.WriteLine("   Count:    {0}", myBA3.Count);
            //Console.WriteLine("   Length:   {0}", myBA3.Length);
            //Console.WriteLine("   Values:");
            //PrintValues(myBA3, 8);

            //Console.WriteLine("myBA4");
            //Console.WriteLine("   Count:    {0}", myBA4.Count);
            //Console.WriteLine("   Length:   {0}", myBA4.Length);
            //Console.WriteLine("   Values:");
            //PrintValues(myBA4, 8);

            //Console.WriteLine("myBA5");
            //Console.WriteLine("   Count:    {0}", myBA5.Count);
            //Console.WriteLine("   Length:   {0}", myBA5.Length);
            //Console.WriteLine("   Values:");
            //PrintValues(myBA5, 8);
        }

        public static void PrintValues(IEnumerable myList, int myWidth)
        {
            int i = myWidth;
            foreach (Object obj in myList)
            {
                if (i <= 0)
                {
                    i = myWidth;
                    Console.WriteLine();
                }
                i--;
                Console.Write("{0,8}", obj);
            }
            Console.WriteLine();
        }

    }
}

