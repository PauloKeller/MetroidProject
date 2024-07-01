using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private bool isAlive = true;

    // TODO: Move to stats
    private int healthPoints = 100;
    private float basicResistence = 0.1f;
    public bool IsAlive
    {
        get
        {
            return isAlive;
        }

        private set
        {
            isAlive = value;
        }
    }

    private SpriteRenderer mySpriteRenderer => GetComponent<SpriteRenderer>();

    // TODO: Move this to "IDamageable" in the future
    public void OnDeath()
    {
        this.healthPoints = 0;
        this.isAlive = false;

        // TODO: Should be remove when start menu is ready
        // just using for testing
        GameObject gameObject = GameObject.FindWithTag("Inventory");
        if (gameObject != null)
        {
            InventoryController inventory = gameObject.GetComponent<InventoryController>();
            inventory.OnPutMaterial();
        }

        Destroy(this.gameObject);
    }
    public void OnTakeShot(IProjectile projectile)
    {
        mySpriteRenderer.color = GetAmmunitionEffect(projectile: projectile);
        healthPoints -= CalculateDamage(projectile: projectile);
        if (healthPoints < 0)
        {
            this.OnDeath();
        }
    }

    // TODO: Move all this bellow into the usecase
    private int CalculateDamage(IProjectile projectile)
    {
        float mitigatedDamage = basicResistence * projectile.Damage;
        int damage = projectile.Damage - Mathf.RoundToInt(mitigatedDamage);

        if (damage < 0)
        {
            return 0;
        }

        return damage;
    }

    // TODO: Ammunition can affect the enemy, add some visual effects to represent this on the future
    private Color GetAmmunitionEffect(IProjectile projectile)
    {
        switch (projectile.ProjectileType)
        {
            case ProjectileType.Metal:
                return Color.gray;
            case ProjectileType.Flammable:
                return Color.red;
            case ProjectileType.Cryogenic:
                return Color.blue;
            case ProjectileType.Chemical:
                return Color.magenta;
            case ProjectileType.Electrical:
                return Color.yellow;
            case ProjectileType.Nuclear:
                return Color.black;
            default:
                return Color.white;
        }
    }
}