
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address) {
        this.name = name;
        this.address = address;
    }
    public Customer(string name, string streetAddress, string city, string stateOrProvince, string country) {
        this.name = name;
        this.address = new Address(streetAddress, city, stateOrProvince, country);
    }

    public bool IsInUSA() {
        return this.address.IsUSA();
    }
    
    public string GetName() {
        return this.name;
    }

    public string GetAddressBlockF() {
        return this.address.GetAllBlockF();
    }
    
    public string GetAddressInlineF() {
        return this.address.GetAllInlineF();
    }
}