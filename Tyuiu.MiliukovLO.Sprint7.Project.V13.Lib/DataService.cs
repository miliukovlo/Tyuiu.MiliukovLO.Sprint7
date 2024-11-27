using System.Diagnostics.Metrics;

namespace Tyuiu.MiliukovLO.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        public List<Country> GetCountries()
        {
            string jsonFilePath = "../../../../Country.json";

            string json = File.ReadAllText(jsonFilePath);

            var countries = new List<Country>();

            json = json.Trim('[', ']');
            var entries = json.Split(new[] { "{", "}," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var entry in entries)
            {
                var country = new Country();
                var properties = entry.Trim('{', '}').Split(',');

                foreach (var property in properties)
                {
                    var keyValue = property.Split(new[] { ':' }, 2);
                    if (keyValue.Length != 2) continue;

                    var key = keyValue[0].Trim().Trim('"');
                    var value = keyValue[1].Trim().Trim('"');

                    if (!string.IsNullOrEmpty(key))
                    {
                        switch (key)
                        {
                            case "CountryName":
                                country.CountryName = value;
                                break;
                            case "Capital":
                                country.Capital = value;
                                break;
                            case "Area":
                                if (long.TryParse(value, out long area))
                                {
                                    country.Area = area;
                                }
                                break;
                            case "Developed":
                                if (bool.TryParse(value, out bool developed))
                                {
                                    country.Developed = developed;
                                }
                                break;
                            case "Population":
                                if (long.TryParse(value, out long population))
                                {
                                    country.Population = population;
                                }
                                break;
                            case "Nation":
                                country.Nation = value;
                                break;
                            case "Note":
                                country.Note = value;
                                break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(country.CountryName))
                {
                    countries.Add(country);
                }
            }
            return countries;

        }
        public List<Country> SearchCountry(string TextBox)
        {
            string jsonFilePath = "../../../../Country.json";

            string json;
            json = File.ReadAllText(jsonFilePath);

            var countries = new List<Country>();
            string filterValue = TextBox.Trim();


            json = json.Trim('[', ']');
            var entries = json.Split(new[] { "{", "}," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var entry in entries)
            {
                var country = new Country();
                var properties = entry.Trim('{', '}').Split(',');

                foreach (var property in properties)
                {
                    var keyValue = property.Split(new[] { ':' }, 2);
                    if (keyValue.Length != 2) continue;

                    var key = keyValue[0].Trim().Trim('"');
                    var value = keyValue[1].Trim().Trim('"');

                    if (!string.IsNullOrEmpty(key))
                    {
                        switch (key)
                        {
                            case "CountryName":
                                country.CountryName = value;
                                break;
                            case "Capital":
                                country.Capital = value;
                                break;
                            case "Area":
                                if (long.TryParse(value, out long area))
                                {
                                    country.Area = area;
                                }
                                break;
                            case "Developed":
                                if (bool.TryParse(value, out bool developed))
                                {
                                    country.Developed = developed;
                                }
                                break;
                            case "Population":
                                if (long.TryParse(value, out long population))
                                {
                                    country.Population = population;
                                }
                                break;
                            case "Nation":
                                country.Nation = value;
                                break;
                            case "Note":
                                country.Note = value;
                                break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(country.CountryName) &&
                    country.CountryName.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    countries.Add(country);
                }
            }
            return countries;
        }
        public List<Country> SortCountry(int index)
        {
            string jsonFilePath = "../../../../Country.json";

            string json = File.ReadAllText(jsonFilePath);
            var countries = new List<Country>();

            json = json.Trim('[', ']');
            var entries = json.Split(new[] { "{", "}," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var entry in entries)
            {
                var country = new Country();
                var properties = entry.Trim('{', '}').Split(',');

                foreach (var property in properties)
                {
                    var keyValue = property.Split(new[] { ':' }, 2);
                    if (keyValue.Length != 2) continue;

                    var key = keyValue[0].Trim().Trim('"');
                    var value = keyValue[1].Trim().Trim('"');

                    if (!string.IsNullOrEmpty(key))
                    {
                        switch (key)
                        {
                            case "CountryName":
                                country.CountryName = value;
                                break;
                            case "Capital":
                                country.Capital = value;
                                break;
                            case "Area":
                                if (long.TryParse(value, out long area))
                                {
                                    country.Area = area;
                                }
                                break;
                            case "Developed":
                                if (bool.TryParse(value, out bool developed))
                                {
                                    country.Developed = developed;
                                }
                                break;
                            case "Population":
                                if (long.TryParse(value, out long population))
                                {
                                    country.Population = population;
                                }
                                break;
                            case "Nation":
                                country.Nation = value;
                                break;
                            case "Note":
                                country.Note = value;
                                break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(country.CountryName)) 
                {
                    countries.Add(country);
                }
            }

            switch (index)
            {
                case 0:
                    return [.. countries.OrderBy(c => c.CountryName)];
                case 1:
                    return [.. countries.OrderBy(c => c.Capital)];
                case 2:
                    return [.. countries.OrderBy(c => c.Area)];
                case 3:
                    return [.. countries.OrderBy(c => c.Developed)];
                case 4:
                    return [.. countries.OrderBy(c => c.Population)];
                case 5:
                    return [.. countries.OrderBy(c => c.Nation)];
                case 6:
                    return [.. countries.OrderBy(c => c.Note)];
                default:
                    return countries;
            }
        }

    }
}
