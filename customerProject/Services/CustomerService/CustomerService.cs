namespace customerProject.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {


        private static List<Customer> customers = new List<Customer>
        {

                new Customer
                {
                    Id = 1,
                    FirstName = "Özge",
                    LastName="Aktaş",
                    EmailAddress="ongunbusra@hotmail.com",
                    MobilePhoneNumber="905334375156",
                    Password="1234"
                },

                   new Customer
                {
                    Id = 2,
                    FirstName = "Esra",
                    LastName="Candan",
                    EmailAddress="ongun.busra@hotmail.com",
                    MobilePhoneNumber="905334375156",
                    Password="1234"
                }

            };


        public List<Customer> AddCustomer(Customer customer)
        {
            customers.Add(customer);

            return customers;
        }

        public List<Customer>? DeleteCustomer(int id)
        {
            var customer = customers.Find(x => x.Id == id);
            if (customer is null)
                return null;

            customers.Remove(customer);
            return customers;
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer? GetSingleCustomer(int id)
        {
            var customer = customers.Find(x => x.Id == id);
            if (customer is null)
                return null;
            return customer;
        }

        public List<Customer>? UpdateCustomer(int id, Customer request) 
        {
            var customer = customers.Find(x => x.Id == id);
            if (customer is null)
                return null;

            customer.FirstName = request.FirstName;
            customer.LastName = request.LastName;
            customer.EmailAddress = request.EmailAddress;
            customer.MobilePhoneNumber = request.MobilePhoneNumber;
            customer.Password = request.Password;

            return customers;



        
        }
    }
}
