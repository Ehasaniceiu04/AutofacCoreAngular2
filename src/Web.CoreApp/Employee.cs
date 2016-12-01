using System;

namespace Web.CoreApp
{
    public class Employee : IEmployee
    {
        bool IEmployee.IsMale(int genderId)
        {
            if (genderId == 1)
                return true;
            else return false;
        }
    }
}