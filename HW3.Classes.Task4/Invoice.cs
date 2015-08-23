using System;

namespace HW3.Classes.Task4
{
    class Invoice
    {
        public readonly int Account;
        public readonly int Customer;
        public readonly double VAT;

        private string _article;
        private int _quantity;
        private double _pricePerUnit;

        public string Article
        {
            get { return _article; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public double PricePerUnit
        {
            get { return _pricePerUnit; }
        }

        public Invoice(int account, int customer, double vat, string article, int quantity, double pricePerUnit)
        {
            Account = account;
            Customer = customer;
            VAT = vat;
            _article = article;
            _quantity = quantity;
            _pricePerUnit = pricePerUnit;
        }

        public double CalcCostWithVAT()
        {
            return CalcCostWithoutVAT() * (1 + VAT);
        }

        public double CalcCostWithoutVAT()
        {
            return _quantity * _pricePerUnit;
        }
    }
}
