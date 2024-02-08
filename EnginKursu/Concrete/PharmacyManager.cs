using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmacyManager : ISuppliersService
    {
        private IApplicantService _applicantService;

        public PharmacyManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine($"Eczaneden türk vatandaşı {person.FirstName} adına Maske Verilemedi");
            }
            else
            {
                Console.WriteLine($"Eczaneden yabancı uyruklu {person.FirstName} adına Maske VERİLDİ");
            }
        }
    }
}
