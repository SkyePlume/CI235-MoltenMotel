﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoltenMotelLib
{
    public class Command
    {
        public String CommandWord { get; set; }
        public String SecondWord { get; set; }
        public String ThirdWord { get; set; }

        public Boolean IsUnknown { get { return (CommandWord == null); } }
    }

}