using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public static class c1
    {
        public static double add(double a, double b)
        {
            return a + b;
        }

        public static int add(string c, string d)
        {
            int a = Convert.ToInt32(c);
            int b = Convert.ToInt32(d);
            return a + b;
        }
        public static int add(string[] st)
        {
            int i = 0;

            foreach (string a in st)
                i += Convert.ToInt32(a);
            return i;
        }
        public static double sub(double a, double b)
        {
            return a - b;
        }

        public static double sub(string c, string d)
        {
            int a = Convert.ToInt32(c);
            int b = Convert.ToInt32(d);
            return a - b;
        }
        public static double sub(string[] st)
        {
            int a = Convert.ToInt32(st[0]);
            int b = Convert.ToInt32(st[1]);
            return a - b;
        }
        public static double mul(double a, double b)
        {
            return a * b;
        }
        public static double mul(string c, string d)
        {
            int a = Convert.ToInt32(c);
            int b = Convert.ToInt32(d);
            return a * b;
        }
        public static double mul(string[] st)
        {
            int i = 1;
            foreach(string a in st)
            
                i *= Convert.ToInt32(a);
                return i;


        }
        public static double div(double a,double b)
        {
            return a / b;
        }
        public static double div(string c, string d)
        {
            int a = Convert.ToInt32(c);
            int b = Convert.ToInt32(d);
            return a / b;
        }
        public static double div(string[] st)
        {
            int a = Convert.ToInt32(st[0]);
            int b = Convert.ToInt32(st[1]);
            return a / b;
        }
        public static double mod(double a,double b)
        {
            return a % b;
        }
        public static double mod(string c,string d)
        {
            int a = Convert.ToInt32(c);
            int b = Convert.ToInt32(d);
            return a % b;
        }
        public static double mod(string[] st)
        {
            int a = Convert.ToInt32(st[0]);
            int b = Convert.ToInt32(st[1]);
            return a%b;
        }
        public static double pow(int a,int b)
        {
            double s = 1;

            if (b > 0)
                for (int i = b; i > 0; i--)
                    s *= a;
            // age b>0,tavan bozorgtar mishe pas *zarb
            if (b < 0)
                for (int i = b; i > 0; i--)
                    s /= a;
            //age b< 0,tavan kochiktar mishe pas /taghsim
            return s;
        }
        public static int pow(string c,string d)
        {
            int a = Convert.ToInt32(c);
            int b = Convert.ToInt32(d);
            return (int)pow(a,b);
        }
        public static int pow(string[] st)
        {
            int a = Convert.ToInt32(st[0]);
            int b = Convert.ToInt32(st[1]);
            return (int)pow(a,b);
        }
    } 
}
