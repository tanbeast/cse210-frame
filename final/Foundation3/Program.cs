using System;

class Address{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country){
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public string GetFullAddress(){
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}

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

class Lecture : Event{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address){
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails(){
        return base.GetStandardDetails() + $"\nEvent Type: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

class Reception : Event{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address){
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails(){
        return base.GetStandardDetails() + $"\nEvent Type: Reception\nRSVP Email: {rsvpEmail}";
    }
}

class OutdoorGathering : Event{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address){
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails(){
        return base.GetStandardDetails() + $"\nEvent Type: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

class Program{
    static void Main(){
        Address address1 = new Address("123 Elm St", "Chicago", "IL", "USA");
        Address address2 = new Address("456 Oak Ave", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Pine Rd", "Toronto", "ON", "Canada");

        Lecture lecture = new Lecture("Advanced Programming Lecture", "A lecture on advanced programming techniques.", new DateTime(2024, 5, 10), "2:00 PM", address1, "Dr. John Smith", 100);
        Reception reception = new Reception("Summer Gala", "An exclusive reception for industry leaders.", new DateTime(2024, 6, 12), "6:00 PM", address2, "rsvp@summerevent.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Music in the Park", "A free concert in the park with local bands.", new DateTime(2024, 7, 20), "4:00 PM", address3, "Clear skies, 75°F");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var eventItem in events){
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine("\n" + eventItem.GetFullDetails());
            Console.WriteLine("\n" + eventItem.GetShortDescription());
            Console.WriteLine("---------------------------------------------------------\n");
        }
    }
}
