using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListBoxMVVM.Utility
{
    public interface IDeepCloneable<T>
    {
        T CreateClone();
    }
}
