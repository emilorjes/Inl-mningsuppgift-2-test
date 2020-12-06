
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Inlämningsuppgift_2_test
{
    class Group
    {
        //----------------------------------------
        // Fields (string)
        //----------------------------------------
        
        private string name;
        private string homeTown;
        private string hobby;
        private string favoriteFood;
        private string favoriteDrink;
        private string favoriteBand;
        private string codeMotivation;
        //----------------------------------------




        //----------------------------------------
        // Fields (int)
        //----------------------------------------
        private int age;
        private int height;
        private int numberOfKids;
        //----------------------------------------




        //----------------------------------------
        // Property (string)
        //----------------------------------------
        
        public string Name
        {
            get { return name; }                         // Går att använda lamba uttryck. Använder dessa för att göra det tydligare att förstå
            set {  name = value; } // Sätter string i set så jag inte behöver skriva ut det flera gånger och det blir exat samma för varje person
        }
        //----------------------------------------
        public string HomeTown
        {
            get { return homeTown; }
            set { homeTown = value; }
        }
        //----------------------------------------
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        //----------------------------------------
        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }
        //----------------------------------------
        public string FavoriteDrink
        {
            get { return favoriteDrink; }
            set { favoriteDrink = value; }
        }
        //----------------------------------------
        public string FavoriteBand
        {
            get { return favoriteBand; }
            set { favoriteBand = value; }
        }
        //----------------------------------------
        public string CodeMotivation
        {
            get { return codeMotivation; }
            set { codeMotivation = value; }
        }
        //----------------------------------------




        //----------------------------------------
        // Property (int)                                // Ändra till string förr att kunna skriva meddelande i "set"??
        //----------------------------------------
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //----------------------------------------
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        //----------------------------------------
        public int NumberOfKids
        {
            get { return numberOfKids; }
            set { numberOfKids = value; }
        }
        //----------------------------------------
       
        
    }
}
