namespace srp.SRPOCP
{
    public class CountryHTMLFormatter : CountryFormatter
    {
        public override string Format(Country country)
        {
            return $"<div class='country'><h1>{country.Name}</h1><h2>{country.Capital}</h2></div>";
        }
    }
}