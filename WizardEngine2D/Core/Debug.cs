using System;
using System.Collections.Generic;
using System.Text;

namespace WizardEngine2D.Core
{
    public abstract class Debug
    {
        public DebugLogEvent mainEvent = new DebugLogEvent(); // USE THIS.(Others won't work....)
        public void Log(string text) //Write to console(shows up as red text with [DEBUG]:) and sends a DebugLogEvent.
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[DEBUG]: "+text);
            mainEvent.log = text;
            mainEvent.Call();
            Console.ResetColor();
        }
        public void Exception(Exception e) //!Don't recommend as it will crash the engine! You may also use this to close the game. Throws an exception and throws a debuglogevent with the log "EXCEPTION" 
        {
            mainEvent.log = "EXCEPTION";
            mainEvent.Call();
            throw e;
        }
    }
}
