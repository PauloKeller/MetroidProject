using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] float speed;
    private Vector2 facingDirection = Vector2.right; 

    private SpriteRenderer mySpriteRenderer => GetComponent<SpriteRenderer>();

    public void BuldProjectile(Vector2 facingDirection, IProjectile projectile) 
    {
        this.facingDirection = facingDirection;

        if (projectile is FlameBullet) 
        {
            mySpriteRenderer.color = Color.red;
        }
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * facingDirection);
    }
}
