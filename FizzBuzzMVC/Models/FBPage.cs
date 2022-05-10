namespace FizzBuzzMVC.Models
{
    public class FBPage
    {
        public int FizzValue { get; set; }
        public int BuzzValue { get; set; }        

        public bool IsFizzBuzz { get; set; }
        // return a css class parameter
        public string GetPaliMessClass()
        {
            return IsFizzBuzz ? "text-success" : "text-danger";
        }

    }
}
