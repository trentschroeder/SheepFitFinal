using System;
using System.ComponentModel.DataAnnotations;
namespace SheepFit6.Models
{
    public class Animal
    {
            public int ID { get; set; }
            public string sheepID { get; set; }
            [Display(Name = "DOB")]
            [DataType(DataType.Date)]
            public DateTime DOB { get; set; }
            public string Gender { get; set; }

    }
}
