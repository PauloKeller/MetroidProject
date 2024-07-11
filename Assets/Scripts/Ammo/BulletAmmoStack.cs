public struct BulletAmmoStack 
{
    public int amount;
    public Bullet bullet;

    public BulletAmmoStack(Bullet bullet, int amount)
    { 
        this.bullet = bullet;
        this.amount = amount;
    }
}
