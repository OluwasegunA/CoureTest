namespace Question2.Models.ViewModel{
  public class CountryModel{
    public string number {get; set;}
    public Countries country {get;set;}
  }

  public class Countries {
    public string countryCode {get; set;}
    public string name {get;set;}
    public string countryIso  {get;set;}
    public List<Details> countryDetails {get; set;}
  }

  public class Details{
    public string countryOperator {get; set;}
    public string operatorCode {get;set;}
  }
}
