using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace FirstResponsiveWebAppMays.Models
{
    public class AgeThisYearModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your birth year.")]
        [Range(1900, 2023, ErrorMessage = "Please enter a year value between 1900 and 2023.")]
        public DateTime Year { get; set; }
        public int AgeThisYear()
        {
            DateTime dec31 = new DateTime(2023, 12, 31);
            return dec31.Year - Year.Year;
        }
        public int AgeToday()
        {
            DateTime today = DateTime.Today;
            DateTime year = Convert.ToDateTime(Year);
            return today. - year.Year;

        }


    }
}

   



