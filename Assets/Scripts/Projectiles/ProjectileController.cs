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
        float angle = 190f;
        Vector2 direction = Quaternion.Euler(0, 0, angle) * facingDirection;
        transform.Translate(direction * speed * Time.deltaTime);
        Debug.Log(facingDirection);
    }
}
