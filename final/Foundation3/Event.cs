
abstract class Event{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string title, string description, DateTime date, string time, Address address){
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetTitle() => title;
    public string GetDescription() => description;
    public DateTime GetDate() => date;
    public string GetTime() => time;
    public Address GetAddress() => address;

    public virtual string GetStandardDetails(){
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress:\n{address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription(){
        return $"Event Type: {this.GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
