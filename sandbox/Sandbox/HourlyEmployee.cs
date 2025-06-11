namespace employee_demo
{
    public class HourlyEmployee : Employee
    {
        private float _payRate = 0;
        private int _hourlyWorked = 0;

        public float GetPayRate()
        {
            return _payRate;
        }

        public void SetPayRate(float payrate)
        {
            _payRate = payrate;
        }

        public int GethourlyWorked()
        {
            return _hourlyWorked;
        }

        public void SethourlyWorked(int hourlyworked)
        {
            _hourlyWorked = hourlyworked;
        }

        public override float GetPay()
        {
            return _hourlyWorked * _payRate;
        }
    }
}
