using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] float speed;
    private Vector2 facingDirection = Vector2.right; 

    public void BuldProjectile(Vector2 facingDirection) 
    {
        this.facingDirection = facingDirection;
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * facingDirection);
    }
}
