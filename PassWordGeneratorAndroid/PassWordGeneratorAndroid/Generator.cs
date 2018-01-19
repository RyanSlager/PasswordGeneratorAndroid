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
            return salt;
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