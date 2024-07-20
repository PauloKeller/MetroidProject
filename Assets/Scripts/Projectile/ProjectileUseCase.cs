using UnityEngine;
public interface IProjectileUseCase 
{
    public float CalculateTravelDistance(Transform transform);
}

public class ProjectileUseCase : IProjectileUseCase
{
    private float totalDistance = 0f;
    private Vector2 previousPosition;

    public ProjectileUseCase(Vector2 initialDistance)
    {
        this.previousPosition = initialDistance;
    }

    public float CalculateTravelDistance(Transform transform) 
    {
        float distanceTraveled = Vector2.Distance(transform.position, previousPosition);
        totalDistance += distanceTraveled;
        //Debug.Log("Distance traveled: " + distanceTraveled.ToString() + "   Total Distance: " + totalDistance.ToString());
        previousPosition = transform.position;

        return totalDistance;
    }
}
