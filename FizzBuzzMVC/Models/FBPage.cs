using System.Collections.Generic;

namespace FizzBuzzMVC.Models
{
    public class FizzBuzz
    {
        public int FizzValue { get; set; }
        public int BuzzValue { get; set; }
        public List<string> Result { get; set; } = new();  // instantiate a new list

        // return a css class parameter to change text color
        public string GetFizzBuzzClass()
        {
            return "FIZZBUZZ"; // IsFizzBuzz ? "text-success" : "text-danger";
        }

    }
}
