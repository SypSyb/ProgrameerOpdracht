using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opdracht;
        
            Console.WriteLine("Typ een opdaracht nummer in");
            opdracht = int.Parse(Console.ReadLine());

            if(opdracht == 1)
            {
                Opdracht1();
            }
            else if(opdracht == 2)
            {
                Opdracht2();
            }
            else if (opdracht == 3)
            {
                Opdracht3();
            }




            

        }

      public static void Opdracht1()
        {
             string zin;
             string langsteWoord = "";
             string[] woorden;

            Console.WriteLine("Typ een zin in:");
            zin = Console.ReadLine();

            woorden = zin.Split(' ');

            int length = 0;
            foreach (String s in woorden)
            {
                if (s.Length > length)
                {
                    langsteWoord = s;
                }
            }



            Console.WriteLine("het Langste woord = {0}", langsteWoord);
            Console.WriteLine("Finished!");
            Console.ReadLine();
        }

        static Char mostRepeated(string s)
        {
            int[] count = new int[256];
            int max = 0;
            Char result = Char.MinValue;

            Array.Clear(count, 0, count.Length - 1);

            foreach (Char c in s)
                if (++count[c] > max)
                {
                    max = count[c];
                    result = c;
                }

            return result;

        }

       public static void Opdracht2()
        {
            Console.WriteLine("Typ een zin in:");
            string zin = Console.ReadLine();
            Console.WriteLine("De meest gebruikte letter = {0}", mostRepeated(zin));
            Console.ReadLine();
        }

        public static void Opdracht3()
        {
            int antwoord = 0;
            string ding;

            List<int> nums = new List<int>();
            Console.WriteLine("Typ een getal in");
            do
            {
                ding = Console.ReadLine();
                if (!ding.Contains("restart") && !ding.Contains("stop"))
                {

                    nums.Add(int.Parse(ding));
                    for (int i = 0; i < nums.Count; i++)
                    {
                        antwoord += nums[i];


                    }
                    antwoord /= nums.Count;
                    Console.WriteLine("Het gemiddelde is: {0}", antwoord);
                    antwoord = 0;
                }
                else
                {
                    if (ding.Contains("restart"))
                    {
                        nums.Clear();
                    }


                }

            }
            while (!ding.Contains("stop"));
        }


    }
}
