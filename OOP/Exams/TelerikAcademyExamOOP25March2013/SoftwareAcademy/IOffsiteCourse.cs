﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }
}
