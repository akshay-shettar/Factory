using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class CharType : Greater<char>
    {
        private char _first;
        private char _second;
        public CharType(char first, char second)
        {
            _first = first;
            _second = second;
        }
        public override char FindGreater()
        {
            return _first.CompareTo(_second) > 1 ? _first : _second;
        }
    }
}
