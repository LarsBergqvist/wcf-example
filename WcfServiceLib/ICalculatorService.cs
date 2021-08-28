using System.ServiceModel;

namespace WcfServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        double Add(double val1, double val2);
        [OperationContract]
        double Subtract(double val1, double val2);
    }
}
