using System.Collections.Generic;

namespace FizzBuzzMVC.Models
{
    public class FizzBuzz
    {
        public int FizzValue { get; set; }
        public int BuzzValue { get; set; }
        public List<string> Results { get; set; } = new();  // instantiate a new list

    }
}
