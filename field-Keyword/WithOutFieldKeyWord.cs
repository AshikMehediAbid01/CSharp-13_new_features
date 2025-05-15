using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace field_Keyword;


public class WithOutFieldKeyWord
{
    private int _price;
    public int Price
    {
        get => _price;
        set
        {
            _price = value;
        }
    }

}
