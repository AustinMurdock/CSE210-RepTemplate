
class Product
{
    private string name;
    private string id;
    private float pricePU;
    private int quantity;

    public Product(string name, string id, float pricePerUnit, int quantity) {
        this.name = name;
        this.id = id;
        this.pricePU = pricePerUnit;
        this.quantity = quantity;
    }

    public float GetTotalCost() {
        return pricePU * quantity;
    }

    public string GetName() {
        return this.name;
    }

    public string GetId() {
        return this.id;
    }
}