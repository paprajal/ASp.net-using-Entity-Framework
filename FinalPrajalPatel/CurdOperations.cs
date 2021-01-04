using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrajalPatel
{
    class CurdOperations
    {
        public static void GetAllCities()
        {
            using (var context = new worldDBEntities())
            {
                var cities = context.Cities.ToList();


                foreach (var city in cities)
                {
                    var capAsk = "";

                    if(city.IsCapital == true)
                    {
                        capAsk = "Yes";
                    }

                    Console.WriteLine($"{city.CityID, -5} {city.CityName, -20} {capAsk, -20} {city.Country.CountryName, -20} {city.Country.Continent.ContinentName, -20} {city.Population, -5}");
                }
            }
        }
        public static void GetAllCountries()
        {
            using (var context = new worldDBEntities())
            {
                var countries = context.Countries.ToList();
                

                foreach (var country in countries)
                {
                    var showCapital = (from s in context.Cities
                                       where s.CountryID == country.CountryID && s.IsCapital == true
                                       select s.CityName).FirstOrDefault();
                    Console.WriteLine($"{country.CountryID,-10} {country.CountryName,-20}  {showCapital, -20}{country.Continent.ContinentName, -20} {country.Language, -20} {country.Currency,-20}");
                }
            }

        }
        public static void GetAllContinents()
        {
            using (var context = new worldDBEntities())
            {
                var contients = context.Continents.ToList();

                foreach (var contient in contients)
                {
                    Console.WriteLine($"{contient.ContinentID, 10} {contient.ContinentName,-10}");
                }
            }

        }
        public static void GetAllCountry()
        {
            using (var context = new worldDBEntities())
            {
                var countries = context.Countries.ToList();

                foreach (var country in countries)
                {
                    Console.WriteLine($"{country.CountryID, 10} {country.CountryName, -10}");
                }
            }

        } 

        public static void GetAllCity()
        {
            using (var context = new worldDBEntities())
            {
                var cities = context.Cities.ToList();

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.CityID,10} {city.CityName,-10}");
                }
            }
        }


        public static void AddNewCountry(string code, string cn,
            string ln, string cu, int bt)
        {
            using (var context = new worldDBEntities())
            {
                
                Country con = new Country();
                
                con.CountryCode = code;
                con.CountryName = cn;
                con.Language = ln;
                con.Currency = cu;
                con.ContinentID = bt;
                

                context.Countries.Add(con);
                context.SaveChanges();

            }

        }
        public static void AddNewCity(string cn, string capp,
            long pop, int cou)
        {
            bool cpp;
            if (capp == "Y" || capp == "y")
            {
                cpp = true;
            }
            else
            {
                cpp = false;
            }
            using (var context = new worldDBEntities())
            {
                

                City ci = new City();

                ci.CityName = cn;
                ci.IsCapital = cpp;
                ci.Population = pop;
                ci.CountryID = cou;


                context.Cities.Add(ci);
                context.SaveChanges();
            }

        }
         public static void GetCityByID(int id)
        {
            using (var context = new worldDBEntities())
            {
                var show = (from a in context.Cities
                              where a.CityID == id
                              select a).FirstOrDefault();

                var capAsk = "";

                if (show.IsCapital == true)
                {
                    capAsk = "Yes";
                }
                else
                {
                    capAsk = "No";
                }
                Console.WriteLine("\nCityID\t CityName\t IsCapital\t Population\t CountryID \n");
                Console.WriteLine($"{show.CityID,5}  {show.CityName, -20}  {capAsk,-10} {show.Population,-20} {show.CountryID, -10} ");
            }
        }
        public static void UpdateCity(int id, string name, string cap, long calc, int uni)
        {
            bool cpp;
            if (cap == "Y" || cap == "y")
            {
                cpp = true;
            }
            else
            {
                cpp = false;
            }
            using (var context = new worldDBEntities())
            {
                City cy = context.Cities.Find(id);

                cy.CityName = name;
                cy.IsCapital = cpp;
                cy.Population = calc;
                cy.CountryID = uni;
                

                context.SaveChanges();
            }

        }

    }
}
