using System;

namespace employee_demo
{
    public abstract class Employee
    {
        protected string _name;
        protected string _idnumber;

        public Employee()
        {

        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetIdnumber()
        {
            return _idnumber;
        }

        public void SetIdnumber(string idnumber)
        {
            _idnumber = idnumber;
        }

        public abstract float GetPay();
    }
}