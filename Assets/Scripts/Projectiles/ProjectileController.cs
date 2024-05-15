using UnityEngine;
using UnityEngine.UIElements;

public class ProjectileController : MonoBehaviour
{
    private Vector2 facingDirection = Vector2.right;
    private IProjectile projectile;

    private SpriteRenderer mySpriteRenderer => GetComponent<SpriteRenderer>();

    public void BuldProjectile(Vector2 facingDirection, IProjectile projectile) 
    {
        this.facingDirection = facingDirection;
        this.projectile = projectile;

        Debug.Log($"Shoting {projectile}");

        if (projectile is FlameBullet) 
        {
            mySpriteRenderer.color = Color.red;
        }
    }

    void Update()
    {
        transform.Translate(facingDirection * this.projectile.Speed * Time.deltaTime);
    }
}
