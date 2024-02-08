 using Entities.Concrete;
using Business.Concrete;
using System;


namespace Workaround
{
    public class Program
    {
        static void Main()

        {
            Person person1 = new Person();
            person1.FirstName = "Eren";
            person1.LastName = "Atasoy";
            person1.NatitonalIdenty = 1453;
            person1.DateOfBirthYear = 2020;

            Person person2 = new Person();
            person2.FirstName = "Necati";
            person2.LastName = "Şaşmaz";
            person2.NatitonalIdenty = 1452;
            person2.DateOfBirthYear = 2010;



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            PharmacyManager pharmacyManager = new PharmacyManager(new ForeignerManager());
            pharmacyManager.GiveMask(person2);
        }

        
        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
    }
}