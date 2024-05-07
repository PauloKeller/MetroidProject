public class MiniGun : Weapon
{
    public MiniGun(IWeapon weapon) : base(weapon)
    {
    }

    public override float Weight => base.Weight;
}