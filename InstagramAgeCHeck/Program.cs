using System;

namespace InstagramAgeCHeck
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog kysib vanust
            //prog kontrollib kas kasutaja on vanem kui 13 v6i 13 aastat vana
            //kui kasutaja on 13 v6i vanem, siis v6ib instat kasutada
            //kui kasutaja on noorem, siis liiga noor
            Console.WriteLine("Palun, sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge > 13)
            {

                Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua.");
            
            }

            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et instagrami'i kasutada");

            }

            else 
            {

                Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua.");



            }

            Console.WriteLine("good day");


        }
    }
}
