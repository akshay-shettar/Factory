using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class CharTypeFactory : ComparorFactory<char>
    {
        private char _first;
        private char _second;
        public CharTypeFactory(char first, char second)
        {
            _first = first;
            _second = second;
        }
        public override char FindGreater()
        {
            return new CharType(_first, _second).FindGreater();
        }
    }
}
