using Volo.Abp.DependencyInjection;

namespace IMM.Signature
{
    public class TaxCalculator : ITaxCalculator ,  ITransientDependency
    {
        public TaxCalculator()
        {

        }

    }
}
