using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class User
    {
        public double Balance { get; set; } = 0;

        public User(double balance)
        {
            Balance = balance;
        }
    }
}
