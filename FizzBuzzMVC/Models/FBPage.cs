namespace FizzBuzzMVC.Models
{
    public class FBPage
    {
        public int MyProperty { get; set; }

        public bool IsFizzBuzz { get; set; }
        // return a css class parameter
        public string GetPaliMessClass()
        {
            return IsFizzBuzz ? "text-success" : "text-danger";
        }

    }
}
