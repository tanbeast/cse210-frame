// Class to represent a Product 
class Product{
    private string name;
    private int productId;
    private decimal pricePerUnit;
    private int quantity;


    public Product(string name, int productId, decimal pricePerUnit, int quantity){
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public decimal GetTotalCost(){
        return pricePerUnit * quantity;
    }

    public string GetPackingLabel(){
        return $"{name} (ID: {productId})";
    }
}