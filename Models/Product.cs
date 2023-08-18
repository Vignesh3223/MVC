using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task_1708.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Required Field")]
        public int PId { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Name Length should between 4-20 Characters")]
        [RegularExpression(@"^([A-za-z ]+)$", ErrorMessage = "Name must contain only alphabets")]
        public string PName { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Range(1, 20, ErrorMessage = "Quantity must be 1-20")]
        public int PQty { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.Currency)]
        public double PPrice { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Range(typeof(DateTime), "01-04-2010", "01-04-2023", ErrorMessage = "Not a Valid Date")]
        public DateTime ManDate { get; set; }

    }
}