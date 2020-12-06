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
                        DeleteMember(participantList);
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
            Console.ForegroundColor = ConsoleColor.Blue;
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
            int i = 1;
            foreach (var member in participantList)
            {
                Console.WriteLine($"{i}. {member}");
                i++;
            }
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
                    GroupMember.HåkanInfo();
                    break;
                case 6:
                    GroupMember.JosefineInfo();
                    break;
                case 7:
                    GroupMember.MattiasInfo();
                    break;
                case 8:
                    GroupMember.NicklasInfo();
                    break;
                case 9:
                    GroupMember.TinaInfo();
                    break;
                case 10:
                    GroupMember.TobiasInfo();
                    break;
            }
        }
        private static void Exit()
        {
            Console.WriteLine("Tack för att du använt mitt program!");
            Environment.Exit(0);
        }
        private static void DeleteMember(List<string> participantList)
        {
            Console.WriteLine("Välj en deltagare du vill ta bort");
            int i = 1;
            foreach (var member in participantList)
            {
                Console.WriteLine($"{i}. {member}");
                i++;
            }
            Console.Write("Ta bort: ");
            int deleteMember = Convert.ToInt32(Console.ReadLine());

            switch (deleteMember)
            {
                case 1:
                    participantList.RemoveAt(0);
                    break;
                case 2:
                    participantList.RemoveAt(1);
                    break;
                case 3:
                    participantList.RemoveAt(2); 
                    break;
                case 4:
                    participantList.RemoveAt(3); 
                    break;
                case 5:
                    participantList.RemoveAt(4); 
                    break;
                case 6:
                    participantList.RemoveAt(5); 
                    break;
                case 7:
                    participantList.RemoveAt(6); 
                    break;
                case 8:
                    participantList.RemoveAt(7); 
                    break;
                case 9:
                    participantList.RemoveAt(8); 
                    break;
                case 10:
                    participantList.RemoveAt(9); 
                    break;

            }

        }
    }
}
