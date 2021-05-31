using System;
using System.Collections.Generic;
using System.Text;

namespace WizardEngine2D.Core
{
    public abstract class Event
    {
        static Func<object, int> eventFunction;
        public void hookFunction(Func<object, int> func) //Hooks a function to an event.
        {
            eventFunction = func;
        }
        public void onCall(object parameter) //Function that does stuff on call.
        {
            eventFunction(parameter);
        }
        public abstract void Call();
    }

    //Debug Events:
    public class DebugLogEvent : Event
    {
        public string log = "";
        public override void Call()
        {
            this.onCall(log);
        }
    }

    //Creation Events:
    public abstract class NewObjectEvent : Event
    {
        public ECS.Entity obj;

        public override void Call()
        {
            this.onCall(obj);
        }
    }
}
