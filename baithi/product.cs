using System;

namespace Java_Csharp_Exam
{
    abstract class Product
    {

        private int _id;
        private string _name;
        private double _price;
        private string _producer;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Producer
        {
            get { return _producer; }
            set { _producer = value; }
        }

        public Product(int _id, string _name, double _price, string _producer)
        {
            this._id = _id;
            this._name = _name;
            this._price = _price;
            this._producer = _producer;
        }

        public int getID()
        {
            return this._id;
        }

        public string getName()
        {
            return this._name;
        }

        public double getPrice()
        {
            return this._price;
        }

        public string getProducer()
        {
            return this._producer;
        }

        public String toString()
        {
            return this._id + ", " + this._name + ", " + this._price + ", " + this._producer;
        }
        public abstract double computeTax();

    }
}