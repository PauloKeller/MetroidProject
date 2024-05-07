using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cannon : IWeapon
{
    public float Weight
    {
        get 
        {
            return 25f;
        }
    }

    public int FireRate
    {
        get
        {
            return 15;
        }
    }

    public int AmmoCapacity
    {
        get 
        {
            return 50;
        }
    }
}
