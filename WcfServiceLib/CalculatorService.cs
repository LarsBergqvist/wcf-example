namespace WcfServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public double Add(double val1, double val2)
        {
            return val1 + val2;
        }

        public double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }
    }
}
