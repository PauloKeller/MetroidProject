public abstract class Bullet: IBullet
{
    protected IBullet receipt;

    public Bullet(IBullet receipt)
    {
        this.receipt = receipt;
    }

    public virtual int Damage
    { 
        get { 
            return receipt.Damage; 
        }
    }

    public virtual float Speed
    {
        get { 
            return receipt.Speed; 
        }
    }
}
