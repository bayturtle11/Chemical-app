using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        //global verible
        static string bigCemical = "";
        static string smallChemical = "";
        static float highChemical = -1;
        static float lowChemical = 5001;

        static void onechamical()
        {


            //display screen
            Console.WriteLine("Welcome to the Chemical app. \n" +
                "Were we do the testing for you\n");

            Console.WriteLine("Plase type in the chemical you are testing");
            string userinput = Console.ReadLine();

            float sumEfficeny = 0;

            Console.WriteLine("please wait");

            for (int i = 0; i < 5; i++)
            {
                // Geneta a number from 5000 to 10000 for the grem count
                Random randomnumber = new Random();
                int germsNumber = randomnumber.Next(5000, 10000);

                Thread.Sleep(500); 
                Console.WriteLine("");
                Console.WriteLine($" number of germs {germsNumber}\n");

                Random randomNumber1 = new Random();
                int germsNumber1 = randomNumber1.Next(0, germsNumber);

                float efficeny = (float)(germsNumber - germsNumber1) / 5;

                sumEfficeny += efficeny;
            }

            float lastEfficeny = sumEfficeny;

            Thread.Sleep(5000);
            Console.WriteLine("please wait will we calute the avgerg efficency of the chemical");
            Thread.Sleep(2000);

            Console.WriteLine($"the chemical {userinput} has an efficency rating of {sumEfficeny} out of 10000");

            if (lastEfficeny > highChemical)
            {
                highChemical = lastEfficeny;
                bigCemical = userinput;
            }
            if (lastEfficeny < lowChemical)
            {
                lowChemical = lastEfficeny;
                smallChemical = userinput;
            }
           


        }
        static void Main(string[] args)
        {
            //loop until user types 'stop'
            string flagmain = "";
            while (!flagmain.Equals("STOP"))
            {
                //call OneChemicals()
                onechamical();

                Console.WriteLine("\nplase enter 'STOP' to qiut or press enter to contue");
                flagmain = Console.ReadLine();


                //loop until user types 'stop'
            }
            //display the Most and Least efficiency chemicals
            Console.WriteLine($"the chemical {bigCemical} is the most efficent chemical for clening with a rating of {highChemical} out 10000\n" +
                $"the chemical {smallChemical} is leat efficent chemical for cleaning with a rating of {lowChemical} out of 10000 ");


        }
    }
}
