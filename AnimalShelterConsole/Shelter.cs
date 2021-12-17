using System;
using System.Collections.Generic;

namespace AnimalShelterConsole
{
    public class Shelter
    {
        List<Dog> dogsList = new List<Dog> { };


        public List<Dog> GetAnimal()
        {
            return this.dogsList;
        }

        public void addAnimal(Dog dog)
        {

            dogsList.Add(dog);

        }

        public void deleteAnimal(string name, int id)
        {

            if (name.Equals(""))
            {
                var itemToRemove = dogsList.Find(dog => dog.Id == id);
                if (itemToRemove != null)
                {
                    dogsList.Remove(itemToRemove);
                    Console.WriteLine("Dog with ID " + id + " removed from the system");
                }
                else
                {
                    Console.WriteLine("Dog doesn't exist in the system");
                }

            }
            else
            {
                var itemToRemove = dogsList.Find(dog => dog.Name == name);
                if (itemToRemove != null)
                {
                    dogsList.Remove(itemToRemove);
                    Console.WriteLine("Dog with name " + name + " removed from the system");
                }
                else
                {
                    Console.WriteLine("Dog doesn't exist in the system");
                }
            }



        }


        public void UpdateAnimal(string previousName, string newName, int previousID, int newID)
        {

            if (previousName.Equals(""))
            {

                var index = dogsList.FindIndex(dog => dog.Id == previousID);



                if (index != -1)
                {
                    if (newID != 0)
                    {
                        dogsList[index].Id = Convert.ToInt32(newID);


                        Console.WriteLine("Previous ID: " + previousID + "\nNew ID: " + newID + "\nSuccessfully changed!");

                    }
                    else
                    {
                        Console.WriteLine("ID can't be 0");
                    }

                }
                else
                {
                    Console.WriteLine("ID doesn't exist");
                }

            }
            else
            {
                var index = dogsList.FindIndex(dog => dog.Name == previousName);

                if (index != -1)
                {
                    if (newName != "")
                    {
                        dogsList[index].Name = newName;
                        Console.WriteLine("Previous name: " + previousName + "\nNew name: " + newName + "\nSuccessfully changed!");
                    }
                    else
                    {
                        Console.WriteLine("Name can't be empty");
                    }

                }
                else
                {
                    Console.WriteLine("Name doesn't exist");
                }


            }

        }

    }
}
