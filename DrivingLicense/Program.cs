using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            
            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBitht = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - yearOfBitht;

            if (userAge < 18)
            {

                Console.WriteLine("Oled liiga noor, et juhilube saada");

            }

            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");

            }

            else
            {

                Console.WriteLine("Palju 6nne! Nyyd saad juhilube taotleda");



            }

            Console.WriteLine("good day");







        }
    }
}
