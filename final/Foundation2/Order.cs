
class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer) {
        this.products = products;
        this.customer = customer;
    }
    public Order(List<Product> products, string name, Address address) {
        this.products = products;
        this.customer = new Customer(name, address);
    }
    public Order(List<Product> products, string name, string streetAddress, string city, string stateOrProvince, string country) {
        this.products = products;
        this.customer = new Customer(name, new Address(streetAddress, city, stateOrProvince, country));
    }

    public float GetTotalCost() {
        float runningTotal = 0.0f;
        // add up all item costs:
        foreach (Product product in this.products) {
            runningTotal += product.GetTotalCost();
        }
        // shipping costs:
        if (customer.IsInUSA()) {
            runningTotal += 5;
        }
        else {
            runningTotal += 35;
        }
        return runningTotal;
    }

    public string GetPackingLabel() {
        string runningString = "";
        foreach (Product product in this.products) {
            runningString += $"{product.GetName()} {product.GetId()}\n";
        }
        return runningString;
    }

    public string GetShippingLabelBlockF() {
        return $"{this.customer.GetName()}\n{this.customer.GetAddressBlockF()}";
    }
    
    public string GetShippingLabelInlineF() {
        return $"{this.customer.GetName()}, {this.customer.GetAddressInlineF()}";
    }
}