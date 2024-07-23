
class Address
{
    private string streetAdd;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string streetAddress, string city, string stateOrProvince, string country) {
        this.streetAdd = streetAddress;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsUSA() {
        if (country == "United States" || country == "United States of America" || country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }

    public string GetAllBlockF() {
        return $"{this.streetAdd}\n{this.city} {this.stateOrProvince}\n{this.country}";
    }
    public string GetAllInlineF() {
        return $"{this.streetAdd} {this.city} {this.stateOrProvince}, {this.country}";
    }
}