using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance_Encapsulation_Namespace
{
    class Employee
    {
       internal string name;
        private string surname;
       protected string address;
        private int _age=20;

        //public Employee(string phone)
        //{
        //    Console.WriteLine(phone);
        //}

        public int Age {
            get
            {
                if (_age < 18)
                {
                    Console.WriteLine("can't see");
                    return -1;
                }
                return _age;

            }




            set
            {
                _age = value;
            }
                
                
                
                
                }









    }
}
