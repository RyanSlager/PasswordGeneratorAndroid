using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PassWordGeneratorAndroid
{
    public static class Generator
    {
        public static string generatePassNum(string salt)
        {
            StringBuilder sb = new StringBuilder();
            int firstPrime = generateRandomPrime();
            int secondPrime = generateRandomPrime();
            int passNum = firstPrime * secondPrime;

            sb.Append(salt);
            sb.Append(passNum.ToString());
         
            return sb.ToString();
        }

        public static int generateRandomPrime()
        {
            Random ran = new Random();
            int ranNum = ran.Next(0, 100);

            while (!isPrime(ranNum))
            {
                ranNum = ran.Next(0, 100);
            }

            return ranNum;
        }

        public static bool isPrime(int n)
        {
            bool prime = true;

            if(n <= 1)
            {
                prime = false;
            }
            else if(n <= 3)
            {
                prime = true;
            }
            else
            {
                int i = 5;
                while(i*i <= n)
                {
                    if(n % i == 0 || n % (i+2) == 0)
                    {
                        prime = false;
                    }
                }
            }

            return prime;
        }
    }
}