using System;
using System.Text;
using System.Linq;

namespace OptionalPar
{
    class webSurvey
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What Is Your Spirit Animal? Take The Quiz To Find Out!");            
            string[] arr = new string[7];
            webSurvey.SpiritAnimal(arr, 0);            
        }


        static void SpiritAnimal(string[] animal, int yearOfBirth)
        {          
            //Randomly select an animal from the array
            Random randAnimal = new Random();            
            animal = new string[] { "Wolverine", "Ant-man", "Thanksgiving Turkey", "Ninja Turtle", "Black Panther", "Batman", "hot dog" };
            int index = randAnimal.Next(animal.Length);
            Console.Write("What year were you born:  ");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());
            //Calculate current age
            var age = (2019 - yearOfBirth);
            Console.WriteLine($"You are a {age} years old {animal[index]}");

            Console.WriteLine("Do you want to try again? yes/no  ");
            bool again = true;
            do
            {
                index = randAnimal.Next(animal.Length);
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.Write("What year were you born:  ");
                    yearOfBirth = Convert.ToInt32(Console.ReadLine());                    
                    age = (2019 - yearOfBirth);
                    Console.WriteLine($"You are a {age} years old {animal[index]}");

                    Console.WriteLine("Do you want to try again? yes/no  ");
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Thank you, bye bye.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Please type in yes or no");
                }
            } while (again == true);
        }
        /*
        static void SpiritAnimal(string[] animal)
        {
            animal = new string[] {"bear", "fox", "Turkey", "turtle","panther","deer","hot dog"};
            SpiritAnimal(animal);
        }*/
    }
}
