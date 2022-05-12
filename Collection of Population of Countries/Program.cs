using System;
using System.Collections.Generic;

namespace Collection_of_Population_of_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            
           NewPlace:

            Console.WriteLine("Enter the name of the country");
            string countryName = Console.ReadLine();
            Country country = new Country(countryName);
            Console.WriteLine("How many city do you add ?");
            int countOfCity = Convert.ToInt32(Console.ReadLine());

            while (countOfCity!=0)
            {
                Console.WriteLine("Enter the name of the city");
                string cityName = Console.ReadLine();              
                Console.WriteLine("Enter the count of the population");
                int population = Convert.ToInt32(Console.ReadLine());
                City city = new City(cityName, population);
                country.Add(city);
                countOfCity--;
                Console.WriteLine("*************");
                Console.WriteLine($"Country name: {countryName} \n********* \nCity Name: {cityName} \n********* \nPopulation of City: {population}\n*********");

            }
            Console.WriteLine("Enter the minimum count");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum count");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***********");
            Console.WriteLine("The city is looking for:");
            country.FindAllByPopulation(min, max);
            country.CountOfPopulation();
            

            goto NewPlace;




        }
    }
}
