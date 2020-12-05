using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift_2_test
{
    class GroupMember : Group
    {
        //----------------------------------------
        // Constructor
        //----------------------------------------
        public GroupMember()
        {
            // Så jag kan skapa upp på olika sätt 
        }
        //----------------------------------------
        public GroupMember
        (string name,                                // Skriver ut dom under varandra för att göra det tydligare
         string homeTown,
         string hobby,
         string favoriteFood,
         string favoriteDrink,
         string favoriteBand,
         string codeMotivation,
         int age,
         int height,
         int numberOfKids
        )
        {
            this.Name = name;
            this.HomeTown = homeTown;
            this.Hobby = hobby;
            this.FavoriteFood = favoriteFood;
            this.FavoriteDrink = favoriteDrink;
            this.FavoriteBand = favoriteBand;
            this.CodeMotivation = codeMotivation;
            this.Age = age;
            this.Height = height;
            this.NumberOfKids = numberOfKids;
        }
        //----------------------------------------




        //----------------------------------------
        // Emil
        //----------------------------------------
        static GroupMember Emil = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Emil Örjes",
            HomeTown = "Falun",
            Hobby = "Snowboard, Gitarr, Musik, Hunden, Tv-spel",
            FavoriteFood = "Feta hamburgare",
            FavoriteDrink = "Öl",
            FavoriteBand = "System Of A Down",
            CodeMotivation = "Att lära sig ett nytt yrke helt från grunden som känns givande",
            Age = 26,
            Height = 184,
            NumberOfKids = 0
        };
        //----------------------------------------
        public static void EmilInfo()
        {
            List<GroupMember> emilInfo = new List<GroupMember>() { Emil };
            foreach (var groupMember in emilInfo)
            {
                Console.WriteLine(groupMember.Name);
                Console.WriteLine(groupMember.Age);
                Console.WriteLine(groupMember.Height);
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------




        //----------------------------------------
        // Benny
        //----------------------------------------
        static GroupMember Benny = new GroupMember() // static för att komma åt object Emil
        {
            Name = "",
            HomeTown = "",
            Hobby = "",
            FavoriteFood = "",
            FavoriteDrink = "",
            FavoriteBand = "",
            CodeMotivation = "",
            Age = 0,
            Height = 0,
            NumberOfKids = 0
        };
        //----------------------------------------
        public static void BennyInfo()
        {
            List<GroupMember> bennyInfo = new List<GroupMember>() { Benny };
            foreach (var groupMember in bennyInfo)
            {
                Console.WriteLine(groupMember.Name);
                Console.WriteLine(groupMember.Age);
                Console.WriteLine(groupMember.Height);
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------





        //----------------------------------------
        // dennis
        //----------------------------------------
        static GroupMember Dennis = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Dennis Lindquist",
            HomeTown = "Älvdalen",
            Hobby = "Gitarr/Musik",
            FavoriteFood = "Friterad kyckling",
            FavoriteDrink = "Öl",
            FavoriteBand = "Metallica",
            CodeMotivation = "Att få skapa och kunna vara kreativ. Men även att få göra ett byte av karriär",
            Age = 32,
            Height = 182,
            NumberOfKids = 1
        };
        //----------------------------------------
        public static void DennisInfo()
        {
            List<GroupMember> dennisInfo = new List<GroupMember>() { Dennis };
            foreach (var groupMember in dennisInfo)
            {
                Console.WriteLine(groupMember.Name);
                Console.WriteLine(groupMember.Age);
                Console.WriteLine(groupMember.Height);
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------




        //----------------------------------------
        // Fredrik
        //----------------------------------------
        static GroupMember Fredrik = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Fredrik Hoffman",
            HomeTown = "Östersund, Odensala",
            Hobby = "musik,socialisera,film,serier,automation och skriptning,programmering,testa nytt,äta ute,whiskykväll och öl",
            FavoriteFood = "Entrecote med rotfrukter och vitlökssmör",
            FavoriteDrink = "Trocadero Zero, Ardbeg och Budvar",
            FavoriteBand = "Armin Van Buuren ",
            CodeMotivation = "Möjlighet till karriärutveckling",
            Age = 28,
            Height = 192,
            NumberOfKids = 0
        };
        //----------------------------------------
        public static void FredrikInfo()
        {
            List<GroupMember> fredrikInfo = new List<GroupMember>() { Fredrik };
            foreach (var groupMember in fredrikInfo)
            {
                Console.WriteLine(groupMember.Name);
                Console.WriteLine(groupMember.Age);
                Console.WriteLine(groupMember.Height);
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------
    }
}
