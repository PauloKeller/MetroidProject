using UnityEngine;

public interface IPlayerUseCaseInterface {
    Vector2 CalculateMovement(Vector2 inputVector);
    public Vector2 FacingDir { get; }
}

public class PlayerUseCase : IPlayerUseCaseInterface
{
    readonly float MoveSpeed = 5f; 

    public Vector2 FacingDir { get;  private set; }

    public PlayerUseCase(float moveSpeed) {
        this.MoveSpeed = moveSpeed;
        this.FacingDir = Vector2.right;
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