


List<string> countriesIveTraveled = new List<string>() { "France", "Germany", "Denmark", "Sweden", "Austria", "Norway", "Netherlands" };

countriesIveTraveled.Add("Iceland");
countriesIveTraveled.Add("Belgium");

var orderedCountries = countriesIveTraveled.OrderByDescending(name => name.Length);

foreach (var countries in orderedCountries)
{
    Console.WriteLine(countries);
}