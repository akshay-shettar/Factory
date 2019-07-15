using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class IntType : Greater<int>
    {
        private int _first;
        private int _second;
        public IntType(int first,int second)
        {
            _first = first;
            _second = second;
        }
        public override int FindGreater()
        {
            return _first > _second ? _first : _second;
        }
    }
}
