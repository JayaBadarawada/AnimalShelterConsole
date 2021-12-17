using System;
namespace AnimalShelterConsole
{
    public class Animal
    {
        public string Name { get; set; }
      
        public int Id { get; set; }


        public void getName(string name)
        {
            Name = name;
        }
        public void setName(string name)
        {
            Name = name;
        }

        public void getId(int id)
        {
            Id = id;

        }

        
    }
}
