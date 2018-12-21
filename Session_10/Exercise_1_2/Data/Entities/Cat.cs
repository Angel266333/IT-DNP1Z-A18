using System;
using System.ComponentModel.DataAnnotations; 

namespace Exercise_1_2
{
    public class Cat
    {
        private int id {get; set;}
        [Required(ErrorMessage = "A name of the kitten is required! Error.")]
        [StringLength (20,MinimumLength=2,ErrorMessage="Name of cat Should be minimum of 2\ncharacters and a maximum of 20 characters")] 
        [DataType(DataType.Text)] 
        private string name {get; set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "No white spaces allowed for cat color.")]
        private string color {get; set;}
        [Required(ErrorMessage = "A value for the price of the kitten is required! Range: 0 to 100.")]
        [Range (0, 100,ErrorMessage="Value of price should be from 0 to 100!")] 
        [DataType(DataType.Currency)] 
        // The question mark after the attribute type declaration
        // represents that this value is optional. --> decimal?
        private decimal? price {get; set;}        
        private DateTime birthdate {get; set;}
        private string favoriteDish {get; set;}
    public Cat(int id, string name, string color, decimal price, DateTime birthdate, string favoriteDish) {
        this.id = id;
        this.name = name;
        this.color = color;
        this.price = price;
        this.birthdate = birthdate;
        this.favoriteDish = favoriteDish;
    }
    }
}
    