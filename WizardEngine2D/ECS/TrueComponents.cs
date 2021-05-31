using System;
using System.Collections.Generic;
using System.Text;

namespace WizardEngine2D.ECS 
{
    class BoolComponent : IGComponent
    {
        public bool toggle;
        public bool ro = false;
        public string name;
        public Entity belongsTo;

        public BoolComponent(bool def = false, string componentName = "Unnamed", Entity BelongsTo = null)
        {
            toggle = def;
            name = componentName;
            belongsTo = BelongsTo;
        }
    }
    class TextComponent : IGComponent
    {
        public string name;
        public string text;
        public bool ro = false;
        public Entity belongsTo;

        public TextComponent(Entity BelongsTo, string ComponentName = "Unnamed", string BaseText = "")
        {
            name = ComponentName;
            belongsTo = BelongsTo;
            text = BaseText;
        }
    }
    class NumberComponent : IGComponent
    {
        public string name;
        public int value;
        public bool ro = false;
        public Entity belongsTo;

        public NumberComponent(Entity BelongsTo, string ComponentName = "Unnamed", int defaultNum = 0)
        {
            belongsTo = BelongsTo;
            name = ComponentName;
            value = defaultNum;
        }
    }
}
