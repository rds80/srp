namespace srp.SRPOCP
{
    public class CountryFormatter
    {
        public virtual string Format(Country country)
        {
            return $"{country.Name}, Capital: {country.Capital} - Region: {country.Region}";
        }
    }
}