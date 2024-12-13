using Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace Tyuiu.MiliukovLO.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        public List<Country> GetCountries()
        {
            string jsonFilePath = "../../../../Country.json";

                string json = File.ReadAllText(jsonFilePath);

                var countries = JsonConvert.DeserializeObject<List<Country>>(json);

                return countries;
        }
        public List<Country> SearchCountry(string filterText)
        {
            string jsonFilePath = "../../../../Country.json";

            string json = File.ReadAllText(jsonFilePath);

            var countries = JsonConvert.DeserializeObject<List<Country>>(json);
            string filterValue = filterText.Trim();
            var filteredCountries = countries.FindAll(country =>
                country.CountryName.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0);

            return filteredCountries;
        }
        public List<Country> SortCountry(int index)
        {
            string jsonFilePath = "../../../../Country.json";

            string json = File.ReadAllText(jsonFilePath);

            var countries = JsonConvert.DeserializeObject<List<Country>>(json);

            switch (index)
            {
                case 0:
                    return countries.OrderBy(c => c.CountryName).ToList();
                case 1:
                    return countries.OrderBy(c => c.Capital).ToList();
                case 2:
                    return countries.OrderBy(c => c.Area).ToList();
                case 3:
                    return countries.OrderBy(c => c.Developed).ToList();
                case 4:
                    return countries.OrderBy(c => c.Population).ToList();
                case 5:
                    return countries.OrderBy(c => c.Nation).ToList();
                case 6:
                    return countries.OrderBy(c => c.Note).ToList();
                default:
                    return countries.ToList();
            }
        }

    }
}
