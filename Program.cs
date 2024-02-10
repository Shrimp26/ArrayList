using System;

//Korzystając z właściwości kolekcji ArrayList(), napisz program, który do kolekcji tego typu dodaje sześć nazw miast:
//Gdańsk, Warszawa, Katowice, Poznań, Kraków, Rzeszów, a następnie je sortuje alfabetycznie.

class Program
{
    static void Main(string[] args)
    {
        System.Collections.ArrayList cities = new System.Collections.ArrayList();

        cities.Add("Gdańsk");
        cities.Add("Warszawa");
        cities.Add("Katowice");
        cities.Add("Poznań");
        cities.Add("Kraków");
        cities.Add("Rzeszów");

        cities.Sort();

        Console.WriteLine("Posortowane miasta: ");
        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
    }
}

