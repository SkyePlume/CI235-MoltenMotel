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
    public class CommandWords
    {
        private static string[] validCommands = { "quit", "test", "help", "engine","clear","room" };
        public string[] ValidCommand { get { return validCommands; } }

        public static Boolean isCommand(string command)
        {
            if (validCommands.Contains(command))
                return true;
            return false;


        }

    }
}
