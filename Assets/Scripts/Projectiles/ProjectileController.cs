using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private Vector2 facingDirection = Vector2.right;
    private IProjectile projectile;
    private IProjectileUseCase useCase;
    private float maxTravelDistance = 0.0f;

    private SpriteRenderer mySpriteRenderer => GetComponent<SpriteRenderer>();

    void Awake()
    {
        this.useCase = new ProjectileUseCase(initialDistance: transform.position);
    }

    public void BuldProjectile(Vector2 facingDirection, IProjectile projectile, float maxTravelDistance) 
    {
        this.maxTravelDistance = maxTravelDistance;
        this.facingDirection = facingDirection;
        this.projectile = projectile;

        Debug.Log($"Shoting {projectile} with MaxTravelDistance: {maxTravelDistance}");
    }

    void Update()
    {
        transform.Translate(facingDirection * this.projectile.Speed * Time.deltaTime);

        float totalDistance = useCase.CalculateTravelDistance(transform);

        if (totalDistance > maxTravelDistance)
        {
            OnMaxRangeReached();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            OnHitEnemy(collision);
        }

        if (collision.tag == "Ground")
        {
            OnHitGround(collision);
        }
    }
    // TODO: Should check the IDamageable interface before take damage
    public void OnHitEnemy(Collider2D collision) 
    {
        EnemyController enemy = collision.GetComponent<EnemyController>();
        if (enemy.IsAlive)
        {
            enemy.OnTakeShot(projectile: projectile);
        }

        if (!projectile.IsPiercing)
        {
            Destroy(this.gameObject);
        }
    }
    public void OnHitGround(Collider2D collision)
    {
        Destroy(this.gameObject);
    }

    public void OnMaxRangeReached()
    {
        Destroy(this.gameObject);
    }
}
