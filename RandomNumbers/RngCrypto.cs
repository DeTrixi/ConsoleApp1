using System;
using System.Security.Cryptography;

namespace RandomNumbers
{
    public class RngCrypto
    {
        public static void RngGetRandomInt(int length, int howMany)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte [length];
                for (int i = 0; i < howMany; i++)
                {
                    rng.GetBytes(data);
                    int value = BitConverter.ToInt32(data, 0);
                    //Console.WriteLine(value);
                }
                Console.WriteLine("This is the RNG int generator");
            }
        }

        public static void RngGetRandomChars(int length, int howMany)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[length];
                for (int i = 0; i < howMany; i++)
                {
                    rng.GetBytes(data);
                    string value = Convert.ToBase64String(data);
                    //Console.WriteLine(value);

                }
                Console.WriteLine("This is the RNG char generator");
            }
        }

        public static void RanGetRandomNumbers(int length, int howMany)
        {
            Random ran = new Random();
            for (int i = 0; i < howMany; i++)
            {
                int data = ran.Next(length);
                //Console.WriteLine(data);

            }
            Console.WriteLine("This is the normal generator");
        }
    }
}