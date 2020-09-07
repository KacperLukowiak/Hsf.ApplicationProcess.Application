using System.ComponentModel.DataAnnotations;

namespace Hsf.ApplicationProcess.August2020.Blazor.Data
{
    public class Applicant
    {
        public int Id { get; set; }

        [MinLength(5, ErrorMessage ="Name must contain atleast 5 characters.")]
        public string Name { get; set; }

        [MinLength(5, ErrorMessage ="Family Name must contain atleast 5 characters.")]
        public string FamilyName { get; set; }

        [MinLength(10,ErrorMessage ="Address must contain atleast 10 characters.")]
        public string Address { get; set; }

        public string CountryOfOrigin { get; set; }

        [EmailAddress(ErrorMessage ="E-Mail adress is not valid.")]
        public string EmailAddress { get; set; }

        [Range(20,60,ErrorMessage ="Age must be between 20 and 60.")]
        public int Age { get; set; }

        public bool Hired { get; set; }
    }
}
