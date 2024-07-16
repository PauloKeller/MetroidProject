public class BaseFuelReceipt : IAmmoReceipt
{
    public int MetalResourceRequired
    {
        get
        {
            return 0;
        }
    }

    public int ChemicalResourceRequired
    {
        get
        {
            return 0;
        }
    }
    public int EnergyResourceRequired
    {
        get
        {
            return 0;
        }
    }

    public int FlammableResourceRequired
    {
        get
        {
            return 2;
        }
    }

    public int CryogenicResourceRequired
    {
        get
        {
            return 0;
        }
    }

    public int RadioactiveMaterialRequired
    {
        get
        {
            return 0;
        }
    }

    public string Name
    {
        get
        {
            return "Ammo Receipt Name";
        }
    }
}
