using System.Security.Cryptography.X509Certificates;

namespace COMP003A.Assignment5
{ //Author: Demetrius Richards
  //Course: COMP-003A-L01
  //Purpose: Assignment 5
    public class TriangleBuilder
    {
        static void Main(string[] args)
        {
            // prompt user to enter single character
            Console.WriteLine("***********************************************");
            Console.WriteLine("Triangle Section");
            Console.WriteLine("***********************************************");            
                Console.WriteLine("Enter a single character: ");
            char inputCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();
                
            int size;
            do
            {
                Console.WriteLine("Enter a positive number:  ");
            }
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0);

            IsoscelesTriangleBuilder(inputCharacter, size);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputCharacter"></param> the character is used to build the triangle
        /// <param name="size"></param> the size of the triangles
        public static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            //increasing of triangle part
            for (int i = 1; i <= size; i++)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }
            //Decreasing part of triangle
            for (int i = size - 1; i >= 1; i--)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("Favorite Characters Section");
                Console.WriteLine("*******************************************");
                PrintSeperator("Favorite Characters");
                CharacterInfo("Mario", 1981);
                CharacterInfo("Spongebob", 1999);
                CharacterInfo("Batman", 1939);
                CharacterInfo("Harry Potter", 1997);
                CharacterInfo("Spongebob", 1999);
            }
        }    
            public static void CharacterInfo(string name, int birthYear)
            {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"Character: {name}, Age {age}");
             

            }
            
        public static int AgeCalculator(int birthYear)
        {
            int currentYear =
            DateTime.Now.Year;
            return currentYear - birthYear;

        }
        /// <summary>
        /// prints a seperatr line for the title
        /// </summary>
        /// <param name="title"></param> The title to display in the seperator
        public static void PrintSeperator(string title)
        {
            Console.WriteLine($"--- {title} ---");
        }
















           

    }
} 