using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class DoubleType : Greater<Double>
    {
        private Double _first;
        private Double _second;
        public DoubleType(Double first, Double second)
        {
            _first = first;
            _second = second;
        }
        public override Double FindGreater()
        {
            return _first > _second ? _first : _second;
        }
    }
}
