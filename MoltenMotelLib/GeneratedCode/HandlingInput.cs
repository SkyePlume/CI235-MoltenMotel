using System.Text;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoltenMotelLib
{
    class HandlingInput
    {
        private Parser parser = new Parser();
        private Boolean finished = false;
        private Motel motel;

        public HandlingInput(Motel m)
        {
            motel = m;
        }
        public void play()
        {
            
            while (!finished && !motel.gameOver)
            {
                Console.Write("Command: ");
                Command command = parser.getCommand();
                finished = processCommand(command);
            }
        }

        private Boolean processCommand(Command c)
        {
            if (c.IsUnknown)
                Console.WriteLine("WHAT?");
            if (c.CommandWord == "quit")
                return true;
            if (c.CommandWord == "clear")
                Console.Clear();
            if (c.CommandWord == "help")
                Console.WriteLine("Keyword - Description\nroom list - Lists all rooms with current satus\nroom report - A broken down version of the list\nengine report - Issues an engine report\nengine recall - Gets the engine back to the station\nengine refill - Fills the engine with coolant\nengine goto roomID - This takes the enigne to the given room\nclear - This clears the game shell\nquit - This quits the game!");
            if (c.CommandWord == "room" && c.SecondWord == "list")
                motel.roomList();
            if (c.CommandWord == "room" && c.SecondWord == "report")
                motel.roomReport();
            if (c.CommandWord == "engine" && c.SecondWord == "report")
                motel.engineReport();
            if (c.CommandWord == "engine" && c.SecondWord == "recall")
                motel.engineRecall();
            if (c.CommandWord == "engine" && c.SecondWord == "refill")
                motel.engineRefill();
            if (c.CommandWord == "engine" && c.SecondWord == "goto")
                motel.goToRoom(Convert.ToInt32(c.ThirdWord));
            return false;
        }
    }
}
