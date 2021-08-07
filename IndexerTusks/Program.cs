using System;

namespace IndexerTusks
{
    class Program
    {
        static void Main(string[] args)
        {
            Team chelsie = new Team();
            chelsie[10] = new Person();
            chelsie[10].Name = "Andrew";
            chelsie[10].Number = 10;
            Person andrew = chelsie[10];
            Console.WriteLine($"{andrew.Name}, {andrew.Number}");

            Dictionary dictionary = new Dictionary();
            dictionary["blue"] = "голубой";
            Console.WriteLine($"{dictionary[0].Source} - {dictionary[0].Target} , {dictionary[1].Source} -" +
                              $" {dictionary[1].Target}, {dictionary[2].Source} - {dictionary[2].Target}");
        }   
    }
}
