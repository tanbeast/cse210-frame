using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        List<Activity> activities = new List<Activity>{
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 5), 45, 15.0),
            new Swimming(new DateTime(2022, 11, 7), 40, 30)
        };

        foreach (var activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}
