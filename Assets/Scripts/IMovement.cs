using UnityEngine;

public interface IMovement
{
    public void MoveToDirectionWithSpeed(GameObject movableObject, Vector3 direction, float speed);
}