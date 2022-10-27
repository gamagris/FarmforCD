namespace FarmforCD.Models
{
    public class Cow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            if(Name.Length <3)
            {
                throw new ArgumentOutOfRangeException("Name cannot be less than 3 characters");
            }
        }    

        override
        public string ToString()
        {
            return $"Cow: {Name} weighs {Weight} pounds.";
        }
    }
}
