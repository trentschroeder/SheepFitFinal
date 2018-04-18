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
            [Display(Name = "Booster")]
            [DataType(DataType.Date)]
            public DateTime Booster { get; set;  }
            [Display(Name = "Wormer")]
            [DataType(DataType.Date)]
            public DateTime Wormer { get; set;  }
            [Display(Name = "Tetanus")]
            [DataType(DataType.Date)]
            public DateTime Tetanus { get; set; }
            [Display(Name = "Pneumonia")]
            [DataType(DataType.Date)]
            public DateTime Pneumonia { get; set; }
            [Display(Name = "Rabies")]
            [DataType(DataType.Date)]
            public DateTime Rabies { get; set; }
            public string Comment { get; set; }

    }
}
