using System;

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
