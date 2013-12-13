using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }
}
