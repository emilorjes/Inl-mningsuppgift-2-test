﻿using System;
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
                Console.WriteLine(Emil.Name); // Räcker att skriva så här och då behövs ingen forech
                Console.WriteLine(groupMember.Name); // Ligger i en lista och foreach är bra att använda
                Console.WriteLine();
                Console.WriteLine(groupMember.Age);
                Console.WriteLine();
                Console.WriteLine(groupMember.Height);
                Console.WriteLine();
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine();
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine();
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine();
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




        //----------------------------------------
        // Håkan
        //----------------------------------------
        static GroupMember Håkan = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Håkan Eriksson",
            HomeTown = "Uppsala",
            Hobby = "Moto-X, Sporthojar, Online gaming",
            FavoriteFood = "Shish kebab",
            FavoriteDrink = "Loka citron",
            FavoriteBand = "Disturbed",
            CodeMotivation = "Social engineering, datasäkerhet, pentesting",
            Age = 44,
            Height = 187,
            NumberOfKids = 0
        };
        //----------------------------------------
        public static void HåkanInfo()
        {
            List<GroupMember> håkanInfo = new List<GroupMember>() { Håkan };
            foreach (var groupMember in håkanInfo)
            {
               
                Console.WriteLine(groupMember.Name); // Ligger i en lista och foreach är bra att använda
                Console.WriteLine();
                Console.WriteLine(groupMember.Age);
                Console.WriteLine();
                Console.WriteLine(groupMember.Height);
                Console.WriteLine();
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine();
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine();
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine();
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------




        //----------------------------------------
        // Josefine
        //----------------------------------------
        static GroupMember Josefine = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Josefine Rönnqvist",
            HomeTown = "Gideå",
            Hobby = "Sy, pussla, umgås",
            FavoriteFood = "Frukt",
            FavoriteDrink = "Vatten",
            FavoriteBand = "Halsbandet",
            CodeMotivation = "Personlig utveckling och karriärbyte",
            Age = 34,
            Height = 164,
            NumberOfKids = 2
        };
        //----------------------------------------
        public static void JosefineInfo()
        {
            List<GroupMember> josefineInfo = new List<GroupMember>() { Josefine };
            foreach (var groupMember in josefineInfo)
            {

                Console.WriteLine(groupMember.Name); // Ligger i en lista och foreach är bra att använda
                Console.WriteLine();
                Console.WriteLine(groupMember.Age);
                Console.WriteLine();
                Console.WriteLine(groupMember.Height);
                Console.WriteLine();
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine();
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine();
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine();
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------




        //----------------------------------------
        // Mattias
        //----------------------------------------
        static GroupMember Mattias = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Mattias Vikström",
            HomeTown = "Umeå",
            Hobby = "Fiske, Matlagning",
            FavoriteFood = "Comboysoppa",
            FavoriteDrink = "Gin och tonic",
            FavoriteBand = "Infected Mushroom",
            CodeMotivation = "Personlig utveckling och kreativitet",
            Age = 33,
            Height = 187,
            NumberOfKids = 0
        };
        //----------------------------------------
        public static void MattiasInfo()
        {
            List<GroupMember> mattiasInfo = new List<GroupMember>() { Mattias };
            foreach (var groupMember in mattiasInfo)
            {

                Console.WriteLine(groupMember.Name); // Ligger i en lista och foreach är bra att använda
                Console.WriteLine();
                Console.WriteLine(groupMember.Age);
                Console.WriteLine();
                Console.WriteLine(groupMember.Height);
                Console.WriteLine();
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine();
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine();
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine();
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------




        //----------------------------------------
        // Nicklas
        //----------------------------------------
        static GroupMember Nicklas = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Nicklas Eriksson",
            HomeTown = "Umeå",
            Hobby = "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel",
            FavoriteFood = "Gröt med jordnötssmör",
            FavoriteDrink = "Whiskey",
            FavoriteBand = "Falling in Reverse och Self Deception",
            CodeMotivation = " Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare ",
            Age = 26,
            Height = 175,
            NumberOfKids = 0
        };
        //----------------------------------------
        public static void NicklasInfo()
        {
            List<GroupMember> nicklasInfo = new List<GroupMember>() { Nicklas };
            foreach (var groupMember in nicklasInfo)
            {

                Console.WriteLine(groupMember.Name); // Ligger i en lista och foreach är bra att använda
                Console.WriteLine();
                Console.WriteLine(groupMember.Age);
                Console.WriteLine();
                Console.WriteLine(groupMember.Height);
                Console.WriteLine();
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine();
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine();
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine();
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------




        //----------------------------------------
        // Tina
        //----------------------------------------
        static GroupMember Tina = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Tina Eriksson",
            HomeTown = "Östersund/Brunflo",
            Hobby = "Spela Tv-spel",
            FavoriteFood = "Potatis och purjolöksoppa",
            FavoriteDrink = "Kaffe",
            FavoriteBand = "Avicci",
            CodeMotivation = "Få ett bra jobb som jag tycker om",
            Age = 30,
            Height = 165,
            NumberOfKids = 2
        };
        //----------------------------------------
        public static void TinaInfo()
        {
            List<GroupMember> tinaInfo = new List<GroupMember>() { Tina };
            foreach (var groupMember in tinaInfo)
            {

                Console.WriteLine(groupMember.Name); // Ligger i en lista och foreach är bra att använda
                Console.WriteLine();
                Console.WriteLine(groupMember.Age);
                Console.WriteLine();
                Console.WriteLine(groupMember.Height);
                Console.WriteLine();
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine();
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine();
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine();
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------




        //----------------------------------------
        // Tobias
        //----------------------------------------
        static GroupMember Tobias = new GroupMember() // static för att komma åt object Emil
        {
            Name = "Tobias Binett",
            HomeTown = "Hudiksvall",
            Hobby = "Träning, Musik, Spel, familjen",
            FavoriteFood = "Kött",
            FavoriteDrink = "Öl",
            FavoriteBand = "The Black Dahlia Murder",
            CodeMotivation = "Få ett bra jobb som jag tycker om",
            Age = 31,
            Height = 192,
            NumberOfKids = 2
        };
        //----------------------------------------
        public static void TobiasInfo()
        {
            List<GroupMember> tobiasInfo = new List<GroupMember>() { Tobias };
            foreach (var groupMember in tobiasInfo)
            {

                Console.WriteLine(groupMember.Name); // Ligger i en lista och foreach är bra att använda
                Console.WriteLine();
                Console.WriteLine(groupMember.Age);
                Console.WriteLine();
                Console.WriteLine(groupMember.Height);
                Console.WriteLine();
                Console.WriteLine(groupMember.HomeTown);
                Console.WriteLine();
                Console.WriteLine(groupMember.NumberOfKids);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteFood);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteDrink);
                Console.WriteLine();
                Console.WriteLine(groupMember.FavoriteBand);
                Console.WriteLine();
                Console.WriteLine(groupMember.Hobby);
                Console.WriteLine();
                Console.WriteLine(groupMember.CodeMotivation);
            }
        }
        //----------------------------------------





    }
}
