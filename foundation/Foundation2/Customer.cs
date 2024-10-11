using System;


class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string CustomerName => _customerName;
    public Address CustomerAddress => _address;

    public bool LivesInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetCustomerDetails()
    {
        return $"Customer: {_customerName}\nAddress: {_address.GetFullAddress}";
    }


}