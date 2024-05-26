using UnityEditor;
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
        Destroy(this.gameObject);
        Debug.Log($"Enemy dead!");
    }
    public void OnTakeShot(IProjectile projectile) 
    {
        Debug.Log($"Hit by {projectile}");
        mySpriteRenderer.color = GetAmmunitionEffect(projectile: projectile);
        healthPoints -= CalculateDamage(projectile: projectile);
        if (healthPoints < 0)
        {
            this.OnDeath();
        }
        Debug.Log($"Enemy health: {healthPoints}");
    }
    
    // TODO: Move all this bellow into the usecase
    private int CalculateDamage(IProjectile projectile) 
    {
        float mitigatedDamage = basicResistence * projectile.Damage;
        Debug.Log($"Mitigate damage: {mitigatedDamage}");

        int damage = projectile.Damage - Mathf.RoundToInt(mitigatedDamage);

        if (damage < 0) 
        {
            return 0;
        }

        Debug.Log($"Will suffer {damage}");

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