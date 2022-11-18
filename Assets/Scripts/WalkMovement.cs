using UnityEngine;

public class WalkMovement : IMovement
{
    public void MoveToDirectionWithSpeed(GameObject moveableObject, Vector3 direction, float speed)
    {
        float normalSpeed = speed * Time.deltaTime;
        moveableObject.transform.localPosition += direction * normalSpeed;
    }
}