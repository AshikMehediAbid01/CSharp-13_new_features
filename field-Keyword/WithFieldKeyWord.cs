using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace field_Keyword;

public class WithFieldKeyWord
{
   
    public string Name
    {
        get => field;
        set
        {
            field = value;
        }
    }
}
