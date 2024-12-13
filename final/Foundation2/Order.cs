
// Class to represent an Order with encapsulation
class Order{
    private Customer customer;
    private List<Product> products;
    private decimal shippingCost;

    public Order(Customer customer){
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product){
        products.Add(product);
    }

    public decimal GetTotalPrice(){
        decimal totalCost = 0;
        foreach (var product in products){
            totalCost += product.GetTotalCost();
        }

        shippingCost = customer.IsFromUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }


    public string GetPackingLabel(){
        string packingLabel = "Packing Label:\n";

        foreach (var product in products){
            packingLabel += product.GetPackingLabel() + "\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel(){
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetFullAddress()}";
    }
}
