using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrajalPatel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\tFINAL EXAM  Prajal Patel");

            do
            {
                int input = DisplayMenu();

                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("\n================================================================================================================\n");
                        Console.WriteLine("\nCityID\t CityName\t IsCapital\t\t CountryName\t ContinentName\t\t Population \n");
                        
                        CurdOperations.GetAllCities();
                
                        break;

                       case 2:
                           Console.WriteLine("\n================================================================================================================\n");
                        Console.WriteLine("\nCountryID\t CountryName\t Capital\t ContinentName\t\t Language\t\t Currency \n");
                        CurdOperations.GetAllCountries();

                       
                        break;

                       case 3:
                           Console.WriteLine("\n================================================================================================================\n"); 
                        Console.Write("Enter Country Code(2 Letters): ");
                        string code = Console.ReadLine();

                        Console.Write("Enter Country Name: ");
                        string cn = Console.ReadLine();

                        Console.Write("Enter Language: ");
                        string ln = Console.ReadLine();

                        Console.Write("Enter Currency: ");
                        string cu = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("ContinentId  ContinentName");
                        Console.WriteLine("\n");
                        CurdOperations.GetAllContinents();
                        Console.WriteLine("\n\n");
                        Console.Write("Enter Continent ID: ");
                        int bt = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");


                        CurdOperations.AddNewCountry(code, cn, ln, cu, bt);
                        Console.Write("New Country is added: ");
                        break;


                         case 4:
                        Console.WriteLine("\n================================================================================================================\n");
                        

                        Console.Write("Enter City Name: ");
                         cn = Console.ReadLine();

                       Console.Write("Enter Is Capital(y/n): ");
                       string capp = Console.ReadLine();

                        Console.Write("Enter Population of city: ");
                        long pop = long.Parse(Console.ReadLine());

                        Console.WriteLine("\n\n");
                        Console.WriteLine("CountryId CountryName");
                        Console.WriteLine("\n");
                        CurdOperations.GetAllCountry();

                        Console.WriteLine("\n\n");
                        Console.Write("Enter Country Id: ");
                        int cou = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");



                        CurdOperations.AddNewCity(cn, capp, pop, cou);
                        Console.Write("New City is added: ");
                        break;

                    case 5:
                        Console.WriteLine("\n================================================================================================================\n");
                        Console.WriteLine("CityId CityName");
                        Console.WriteLine("\n");
                        CurdOperations.GetAllCity();
                        Console.WriteLine("\n");
                        Console.Write("Enter city ID (which data will you want to update): ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("---------------------- Old Data of city ID ----------------------\n");
                        Console.WriteLine("\n");
                        CurdOperations.GetCityByID(id);
                        Console.WriteLine("\n");
                        Console.WriteLine("\n----------------------- Enter new data of city ----------------------");
                        Console.WriteLine("\n");

                        Console.Write("Enter City Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Capital(y/n): ");
                       string cap =Console.ReadLine();

                        Console.Write("Enter Population of city: ");
                        long calc = long.Parse(Console.ReadLine());

                        Console.WriteLine("\n");
                        Console.WriteLine("CountryId CountryName");
                        Console.WriteLine("\n");
                        CurdOperations.GetAllCountry();
                        Console.WriteLine("\n");

                        Console.Write("Enter Country Id: ");
                        int uni = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");



                        CurdOperations.UpdateCity(id, name, cap, calc, uni);
                        Console.Write("New City is updated: ");
                        break;

                    case 6:
                           Environment.Exit(0);
                           break;

                       default:
                           Console.WriteLine("\n........ PLEASE ENTER VALID INPUT......");
                            break;
                   }
                } while (true);


            }

        static int DisplayMenu()
        {

            Console.WriteLine("\n\n================================================================================================================\n");
            Console.WriteLine("\t 1. Get all Cities");
            Console.WriteLine("\t 2. Get all Countries");
            Console.WriteLine("\t 3. Add new Country");
            Console.WriteLine("\t 4. Add new City");
            Console.WriteLine("\t 5. Update a city");
            Console.WriteLine("\t 6. Exit");

            Console.Write("\n\nEnter your choice: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
