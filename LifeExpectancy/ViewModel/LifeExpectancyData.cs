using System.Reflection;

namespace LifeExpectancy
{
    public class LifeExpectancyData
    {

        List<LifeExpectancyModel> allCountriesdata;

        public List<LifeExpectancyModel> AllCountriesData
        {
            get
            {
                return allCountriesdata;
            }
            set
            {
                allCountriesdata = value;
            }
        }

        List<LifeExpectancyModel> asianCountries;
        public List<LifeExpectancyModel> AsianCountries
        {
            get
            {
                return asianCountries;
            }
            set
            {
                asianCountries = value;
            }
        }

        List<LifeExpectancyModel> africanCountries;
        public List<LifeExpectancyModel> AfricanCountries
        {
            get
            {
                return africanCountries;
            }
            set
            {
                africanCountries = value;
            }
        }

        List<LifeExpectancyModel> southAmerica;
        public List<LifeExpectancyModel> SouthAmerica
        {
            get
            {
                return southAmerica;
            }
            set
            {
                southAmerica = value;
            }
        }

        List<LifeExpectancyModel> northAmerica;
        public List<LifeExpectancyModel> NorthAmerica
        {
            get
            {
                return northAmerica;
            }
            set
            {
                northAmerica = value;
            }
        }

        List<LifeExpectancyModel> oceania;
        public List<LifeExpectancyModel> Oceania
        {
            get
            {
                return oceania;
            }
            set
            {
                oceania = value;
            }
        }

        List<LifeExpectancyModel> europe;
        public List<LifeExpectancyModel> Europe
        {
            get
            {
                return europe;
            }
            set
            {
                europe = value;
            }
        }

        List<LifeExpectancyModel> others;
        public List<LifeExpectancyModel> Others
        {
            get
            {
                return others;
            }
            set
            {
                others = value;
            }
        }
        public LifeExpectancyData()
        {
            AllCountriesData = new List<LifeExpectancyModel>(ReadCSV());
            AsianCountries = AllCountriesData.Where(d => d.Continent == "Asia").ToList();
            AfricanCountries = AllCountriesData.Where(d => d.Continent == "Africa").ToList();
            Europe = AllCountriesData.Where(d => d.Continent == "Europe").ToList();
            SouthAmerica = AllCountriesData.Where(d => d.Continent == "South America").ToList();
            NorthAmerica = AllCountriesData.Where(d => d.Continent == "North America").ToList();
            Oceania = AllCountriesData.Where(d => d.Continent == "Oceania").ToList();
            Others = AllCountriesData.Where(d => d.Continent == "").ToList();
        }
        public static IEnumerable<LifeExpectancyModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("LifeExpectancy.Resources.Raw.data.csv");

            string line;
            List<string> lines = new();

            using StreamReader reader = new(inputStream);
            while((line = reader.ReadLine())!= null)
            {
                lines.Add(line);
            }

            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new LifeExpectancyModel(data[0], Convert.ToDouble(data[1]), Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), data[4]);
            });
        }
    }
}
