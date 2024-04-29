using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    public class AnimalContext 
    {
        public AnimalContext Init;
        public List<Animal> Animals { get; set; }
        public List<Species> Species { get; set; }

        public AnimalContext() {
            
           Animals = new List<Animal>();
            Species = new List<Species>();
        }
    }

    public class Animal
    {
        public Animal Init;
        public Guid AnimalId { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Species Species { get; set; }
        public Animal()
        {
      
        }
    }

    public class Species
    {
        public Species Init;
        public Guid SpeciesId { get; set; }
        public String Name { get; set; }
        public Species()
        {
       
        }
    }

    public class Program
    {
       

        public static void Main()
        {
            AnimalContext animal = new AnimalContext();
            for (int i = 0; i < 3; i++)
            {
                
                Species espece = new Species();
                espece.Name = "Cougar";
                animal.Species.Add(espece);
              

            }
            for (int i = 0; i < 100; i++)
            {
               
                Species espece = new Species();
                espece.Name = "Tigre";
                animal.Species.Add(espece);
            }
            for (int i = 0; i < 15; i++)
            {
               
                Species espece = new Species();
                espece.Name = "Tortue";
                animal.Species.Add(espece);
            }
          
                var whiteCougarSpecies = from spec in animal.Species
                                         where spec.Name == "Cougar"
                                         select spec;
            var whiteTigerSpecies = from spec in animal.Species
                                     where spec.Name == "Tigre"
                                     select spec;
            var whiteTurtleSpecies = from spec in animal.Species
                                    where spec.Name == "Tortue"
                                    select spec;
            Console.WriteLine("Cougars ="+whiteCougarSpecies.Count());
            Console.WriteLine("Tigres="+whiteTigerSpecies.Count());
            Console.WriteLine("Tortues"+whiteTurtleSpecies.Count());
        }
    }
}