using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class IntTypeFactory : ComparorFactory<int>
    {
        private int _first;
        private int _second;
        public IntTypeFactory(int first, int second)
        {
            _first = first;
            _second = second;
        }
        public override int FindGreater()
        {
            return new IntType(_first, _second).FindGreater();
        }
    }
}
