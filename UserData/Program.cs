using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //prograbb artvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBitht = Convert.ToInt32 (Console.ReadLine());
            int userAge = 2021 - yearOfBitht;

            //Console.WriteLine("Oled " + userAge + "aastat vana.");

            //string intropolation


            Console.WriteLine($"Oled {userAge} aastat vana");
        
        
        
        }
    }
}
