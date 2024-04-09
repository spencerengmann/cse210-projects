public class Address
{
    private string street;
    private string city;
    private string state;
    private int zipCode;

    public Address(string street, string city, string state, int zipCode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    public string GetAddress()
    {
        return $"{street}, {city}, {state} {zipCode}";
    }

}