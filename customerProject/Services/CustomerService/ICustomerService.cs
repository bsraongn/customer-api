using Microsoft.AspNetCore.Mvc;

namespace customerProject.Services.CustomerService
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer? GetSingleCustomer(int id);
        List<Customer> AddCustomer(Customer customer);
        List<Customer>? UpdateCustomer(int id, Customer request);
        List<Customer>? DeleteCustomer(int id);

    }
}
