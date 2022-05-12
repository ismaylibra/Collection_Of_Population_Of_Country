using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection_of_Population_of_Countries
{
    class Country
    {
        public string Name;
        public static int TotalPopulation;
        public ArrayList Cities;
        public Country(string name )
        {
            Name = name;
            Cities = new ArrayList();
            
        }
        public void Add(City city)
        {
            Cities.Add(city);
        }
        public void FindAllByPopulation(int min, int max)
        {
            foreach (City items in Cities)
            {
                if (items.Population>min&&items.Population<max)
                {
                    Console.WriteLine(items);
                }
            }
        }
        public  void  CountOfPopulation()
        {
           

            foreach (City cities in Cities)
            {

                TotalPopulation += cities.Population;
               
            }
            Console.WriteLine("************");
            Console.WriteLine($"Population  of Country: {TotalPopulation}");
        }
       
        



    }
}
