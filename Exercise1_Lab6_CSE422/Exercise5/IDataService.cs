﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public interface IDataService<T>
    {
        string GetData(int id);
    }

}
