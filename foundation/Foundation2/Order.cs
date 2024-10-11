using System;
class Order
{
    private Customer _customer;
    private List<Product>_products = new List<Product>();

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);    
    }

    public double GetTotal()
    {
        double total =0;
        foreach(var product in _products)
        {
            total += product.GetTotalPrice();
        }

        double fee = _customer.CustomerAddress.IsInUsa() ? 5 : 35;
        total += fee;
        return total;
        
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (var product in _products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.CustomerName}\n{_customer.CustomerAddress.GetFullAddress()}";
    }

}