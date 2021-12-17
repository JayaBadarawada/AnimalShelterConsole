using System;

namespace AnimalShelterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var shelter = new Shelter();
            var animals = shelter.GetAnimal();

            string answer = "";
            int dogsID = 0;

            menu();

            void createDog()
            {
                Console.WriteLine("Write dog's Name: ");
                string dogName = Console.ReadLine();
                dogsID = dogsID + 1;
                int giveIDtoTheDog = dogsID;
                Console.WriteLine("* Dog name is: " + dogName + ".   Dog ID is: " + giveIDtoTheDog + "     \n\n");

                var dog = new Dog()
                {
                    Name = dogName,
                    Id = giveIDtoTheDog
                };
                shelter.addAnimal(dog);
                menu();

            }



            void lookAllDags()
            {
                Console.WriteLine(" \n \n-------------------------------------------");
                Console.WriteLine("LIST OF ALL DOGS:  ");
                Console.WriteLine("...........................................");

                foreach (Animal animal in animals)
                {
                    Console.WriteLine("Name: " + animal.Name + "        ID: " + animal.Id);
                }
                Console.WriteLine("-------------------------------------------\n \n  ");
                menu();
            }

            void deleteDog()
            {
              
                Console.WriteLine("To delete dog by name press   1\nTo delete dog by ID press     2\nTo look all dogs press        3\nBack to menu press            4");
                string chooseToDeleteBy = Console.ReadLine();
                string dogName = "";
                int dogId = 0;

                if (chooseToDeleteBy == "1")
                {
                    Console.WriteLine("Wtite dog's name: ");
                    dogName = Console.ReadLine();
                    shelter.deleteAnimal(dogName, dogId);
                    menu();


                }
                else if (chooseToDeleteBy == "2")
                {
                    Console.WriteLine("Wtite dog's ID: ");
                    dogId = Int32.Parse(Console.ReadLine());
                    shelter.deleteAnimal(dogName, dogId);
                    menu();
                }
                else if (chooseToDeleteBy == "3")
                {
                    lookAllDags();

                }
                else
                {
                    menu();
                }



            }


            void titleAndAnswer()
            {



                Console.WriteLine(" Press:  ");
                Console.WriteLine(" 1 Create a new dog.\n 2 Look all dogs.\n 3 Delete dog.\n 4 Update dog");


                Console.WriteLine("*****************************************************");
                answer = Console.ReadLine();
                Console.WriteLine("You pressed: " + answer);

            }

            void updateDog()
            {
                Console.WriteLine("To update dog's name press   (1)\nTo update dog's ID press     (2) ");
                string chooseToUpdate = Console.ReadLine();
                string previousName = "";
                string newName = "";
                int previousID = 0;
                int newID = 0;
                if (chooseToUpdate == "1")
                {
                    Console.WriteLine("Write previos name: ");
                    previousName = Console.ReadLine();
                    Console.WriteLine("Write new name: ");
                    newName = Console.ReadLine();
                    shelter.UpdateAnimal(previousName, newName, previousID, newID);
                }
                else if (chooseToUpdate == "2")
                {

                    Console.WriteLine("Write previos ID (numbers only): ");
                    previousID = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Write new ID (numbers only): ");
                    newID = Int32.Parse(Console.ReadLine());
                    shelter.UpdateAnimal(previousName, newName, previousID, newID);
                }
                else
                {
                    menu();
                }
                menu();

            }



            void menu()
            {
                titleAndAnswer();

                if (answer == "1")
                {
                    createDog();
                }
                else if (answer == "2")
                {
                    lookAllDags();
                }
                else if (answer == "3")
                {
                    deleteDog();
                }
                else if (answer == "4")
                {
                    updateDog();
                }
                else
                {
                    Console.WriteLine("You can only choose between 1, 2, 3 and 4");
                    titleAndAnswer();
                }

            }
        }
    }
}
