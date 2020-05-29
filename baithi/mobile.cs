using System;

namespace Java_Csharp_Exam
{
    internal class MobilePhone : Product
    {
        public MobilePhone(int _id, string _name, double _price, string _producer)
            : base(_id, _name, _price, _producer)
        {
        }

        public override double computeTax()
        {
            return getPrice() * 10 / 100;
        }
    }
}