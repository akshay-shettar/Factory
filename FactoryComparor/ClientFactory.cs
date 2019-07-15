using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryComparor
{
    public class ComparatorImpl<T>
    {
        public T FindGreater(T first, T second)
        {
            Type type = first.GetType();

            string _first = first.ToString();
            string _second = second.ToString();

            if (type == typeof(string))
            {
                return (T)Convert.ChangeType(new StringTypeFactory(_first, _second).FindGreater(), typeof(T));
            }
            if (type == typeof(int))
            {
                return (T)Convert.ChangeType(new IntTypeFactory(int.Parse(_first), int.Parse(_second)).FindGreater(), typeof(T));
            }
            if (type == typeof(Double))
            {
                return (T)Convert.ChangeType(new DoubleTypeFactory(Double.Parse(_first), Double.Parse(_second)).FindGreater(), typeof(T));
            }
            if (type == typeof(char))
            {
                return (T)Convert.ChangeType(new CharTypeFactory(char.Parse(_first), char.Parse(_second)).FindGreater(), typeof(T));
            }
            return default(T);
        }
    }
}
