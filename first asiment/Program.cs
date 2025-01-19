using System;

namespace first_asiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Q1
            //Console.WriteLine("Pelese Enter Number");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("The User Enter Number : " + x);
            //#endregion


            //#region Q2          
            //int Num1 = 10;
            //    int Num2 = Num1;

            //    Console.WriteLine("-----------Before -----------");
            //    Console.WriteLine("number1 = " + Num1);
            //    Console.WriteLine("number2 = " + Num2);

            //    // Modify the value of num1
            //    Num1 = 20;

            //    Console.WriteLine("-----------After -----------");
            //    Console.WriteLine("number1 = " + Num1);
            //    Console.WriteLine("number2 = " + Num2);

            //    // Explanation of output:
            //    Console.WriteLine("\nExplanation:");
            //    Console.WriteLine("When number1 was assigned to number2, a copy of the value was made.");
            //    Console.WriteLine("Changing number1 does not affect number2, as they are stored in separate memory locations.");
            //#endregion


            #region Q3
            // Create an instance of a reference type (class)
            Console.WriteLine("--------Before-------");
            point p1 = new point();
            Console.WriteLine(p1.GetHashCode());
            point P2 = new point();
            Console.WriteLine(P2.GetHashCode());

            Console.WriteLine("--------After-------");
            P2 = p1;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(P2.GetHashCode());






            // Explanation of output:
            Console.WriteLine("\nExplanation:");
            Console.WriteLine("When person1 was assigned to person2, both variables referred to the same object in memory.");
            Console.WriteLine("Modifying the object through person1 also affected person2, as they share the same reference.");




            #endregion

        }





    }









}


