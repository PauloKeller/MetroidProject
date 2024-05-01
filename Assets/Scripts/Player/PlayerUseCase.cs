using UnityEngine;

public interface IPlayerUseCaseInterface {
    Vector2 CalculateMovement(Vector2 inputVector);
    public Vector2 FacingDir { get; }
    public IProjectile CraftBullet();
}

public class PlayerUseCase : IPlayerUseCaseInterface
{
    public int metallicComponentsAmount = 0;
    public int chemicalSubstancesAmount = 0;
    public int flammableFuelAmount = 0;
    public int powerBatteryAmount = 0;
    public int cryogenicGasesAmount = 0;
    public int nuclearMaterialsAmount = 0;

    readonly float MoveSpeed = 5f; 

    public Vector2 FacingDir { get;  private set; }

    public PlayerUseCase(float moveSpeed) {
        this.MoveSpeed = moveSpeed;
        this.FacingDir = Vector2.right;
    }

    public IProjectile CraftBullet() {
        int metallicsReq = 0;
        int flammableReq = 0;
        
        Bullet bullet = new Bullet();

        if (true) 
        {
            metallicsReq = 10;
            flammableReq = 5;

            return new FlameBullet(bullet);
        }

        return bullet;
    }

    public Vector2 CalculateMovement(Vector2 inputVector)
    {
        if (inputVector.normalized != Vector2.zero) 
        {
            this.FacingDir = inputVector.normalized;
        }
        
        Vector2 movementVector = inputVector * MoveSpeed;

        return movementVector;
    }
} 