using System;

class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _quantity;

    // Constructors
    public Product(string productName, string productId, double productPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _quantity = quantity;
    }


    // Method to calculate the total price.
    public double GetTotalPrice()
    {
        return _productPrice * _quantity;
    }

    public string ProductName => _productName;
    public string ProductId => _productId;
    public int Quantity => _quantity;
    public double ProductPrice => _productPrice;


    //Method to show the details of the product.
    public string GetProductDetails()
    {
        return $"ID: {ProductId} | Product: {ProductName} | Price: {ProductPrice} | Quantity: {Quantity}";
    }
}