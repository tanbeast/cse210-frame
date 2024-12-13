
// Class to represent a Customer
class Customer{
    private string name;
    private Address address;


    public Customer(string name, Address address){
        this.name = name;
        this.address = address;
    }

    public string GetName(){
        return name;
    }

    public bool IsFromUSA(){
        return address.IsInUSA();
    }

    public string GetFullAddress(){
        return address.GetFullAddress();
    }
}
