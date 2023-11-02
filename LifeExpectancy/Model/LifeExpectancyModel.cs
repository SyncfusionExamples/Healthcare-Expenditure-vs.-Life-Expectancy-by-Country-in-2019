
namespace LifeExpectancy
{
    public class LifeExpectancyModel
    {
        public string Country { get; set; }
        public double LifeExpectancy { get; set; }
        public double HealthExpenditure { get; set; }
        public double Population { get; set; }
        public string Continent { get; set; }

        public LifeExpectancyModel(string country,double lifeExpectancy,double healthExpenditure,double population,string continent)
        {
            Country = country;
            LifeExpectancy = lifeExpectancy;
            HealthExpenditure = healthExpenditure;
            Population = population;
            Continent = continent;
        }
    }
}
