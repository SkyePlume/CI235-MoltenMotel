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
using System.Threading;
using System.Threading.Tasks;

namespace MoltenMotelLib
{

    public class Program
    {

        static void Main(string[] args)
        {
            Game g = new Game();
            TimerCallback moltenMotel = g.tickTock;
            Timer tmr = new Timer(moltenMotel, null, 1000, g.RefreshRate);
            
            g.gameStart();

        }


    }
}