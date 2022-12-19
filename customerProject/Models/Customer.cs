namespace customerProject.Models
{
    public class Customer
    {

        public int Id { get; set; }

        public String FirstName { get; set; } = string.Empty;  /*Empty kısmı nullable için, boş olabilir yani*/
        
        public String LastName { get; set; } = string.Empty;
        
        public String EmailAddress { get; set; } = string.Empty;

        public String MobilePhoneNumber { get; set; } = string.Empty;

        public String Password { get; set; } = string.Empty;
    }
}
