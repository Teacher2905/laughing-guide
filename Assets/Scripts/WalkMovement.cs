using UnityEngine;

public class WalkMovement : IMovement
{
    public void MoveToDirectionWithSpeed(GameObject moveableObject, Vector3 direction, float speed)
    {
        float relativeSpeed = speed * Time.deltaTime;
        moveableObject.transform.localPosition += direction * relativeSpeed;
    }
}