using UnityEngine;
using UnityEngine.UIElements;

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
        float angle = 315f;
        if (facingDirection == Vector2.left) 
        {
            angle = -angle;
        }

        Vector2 direction = Quaternion.Euler(0, 0, angle) * facingDirection;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
