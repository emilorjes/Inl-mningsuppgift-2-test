using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift_2_test
{
    class Menu
    {
        public static void StartProgram() // Satt till public för att komma åt
        {
            
            List<string> participantList = new List<string>()
            {"Benny", "Dennis", "Emil", "Fredrik", "Håkan", "Josefine", "Mattias", "Nicklas", "Tina", "Tobias" };

            LoginCode();
            StartMenu(participantList);

        }

        private static void StartMenu(List<string> participantList)
        {
            Console.WriteLine("Snyggt rätt kod!");
            do
            {
               
                Console.WriteLine("1.  Deltagare");
                Console.WriteLine("2.  Ta bort deltagare");
                Console.WriteLine("3.  Exit");
                Console.Write("Välj alternativ: ");
                int menuChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menuChoice)
                {
                    case 1:
                        MembersMenu(participantList);
                        break;
                    case 2:
                        break;
                    case 3:
                        Exit();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (true);
           
        }

        private static void LoginCode()
        {
            string secretCode = "norrlänningarna";
            string loginCode;
            Console.WriteLine("Ange basgruppens kod för att fortsätta");

            do
            {
                Console.Write("SKriv in lösenord: ");
                loginCode = Console.ReadLine();
                if (loginCode != secretCode)
                {
                    Console.Clear();
                    Console.WriteLine("Ajdå det blev visst fel, försök igen");

                }

            } while (loginCode != secretCode);
            Console.Clear();
        }

        private static void MembersMenu(List<string> participantList)
        {
            Console.WriteLine($"Deltagare: {string.Join(',', participantList)}");
            Console.WriteLine("Meny");
            Console.WriteLine("1.  Benny");
            Console.WriteLine("2.  Dennis");
            Console.WriteLine("3.  Emil");
            Console.WriteLine("4.  Fredrik");
            Console.WriteLine("5.  Håkan");
            Console.WriteLine("6.  Josefine");
            Console.WriteLine("7.  Mattias ");
            Console.WriteLine("8.  Nicklas");
            Console.WriteLine("9.  Tina");
            Console.WriteLine("10. Tobias");
            Console.Write("Välj menyval: ");
            int memberChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (memberChoice) // om det hade varit 9 menyval hade jag använt char
            {
                case 1:
                    GroupMember.BennyInfo();
                    break;
                case 2:
                    GroupMember.DennisInfo();
                    break;
                case 3:
                    GroupMember.EmilInfo();
                    break;
                case 4:
                    GroupMember.FredrikInfo();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
            }
        }
        private static void Exit()
        {
            Console.WriteLine("Tack för att du använt mitt program!");
            Environment.Exit(0);
        }
    }
}
