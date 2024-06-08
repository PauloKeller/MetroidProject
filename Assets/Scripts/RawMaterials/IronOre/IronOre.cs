using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IronOre : IRawMaterial
{
    public float Weight
    {
        get 
        {
            return 1.5f;
        }
    }

    public int MaxStack
    {
        get 
        {
            return 9999;
        }
    }

    // TODO: Should point to the translation table id
    public string Description
    {
        get
        {
            return "Iron ores are rocks and minerals from which metallic iron can be economically extracted.";
        }
    }
}