using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Java_Csharp_Exam
{
    class Book : Product
    {
        public Book(int _id, string _name, double _price, string _producer)
            : base(_id, _name, _price, _producer)
        {

        }

        public override double computeTax()
        {
            return getPrice() * 8 / 100;
        }

    }
}