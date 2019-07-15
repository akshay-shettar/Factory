using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class DoubleTypeFactory : ComparorFactory<Double>
    {
        private Double _first;
        private Double _second;
        public DoubleTypeFactory(Double first, Double second)
        {
            _first = first;
            _second = second;
        }
        public override Double FindGreater()
        {
            return new DoubleType(_first, _second).FindGreater();
        }
    }
}
