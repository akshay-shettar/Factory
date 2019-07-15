using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class StringTypeFactory : ComparorFactory<string>
    {
        private string _first;
        private string _second;
        public StringTypeFactory(string first, string second)
        {
            _first = first;
            _second = second;
        }
        public override string FindGreater()
        {
            return new StringType(_first, _second).FindGreater();
        }
    }
}
