using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class StringType : Greater<string>
    {
        private string _first;
        private string _second;
        public StringType(string first, string second)
        {
            _first = first;
            _second = second;
        }
        public override string FindGreater()
        {
            return String.Compare(_first, _second) > 0 ? _first : _second;
        }
    }
}
