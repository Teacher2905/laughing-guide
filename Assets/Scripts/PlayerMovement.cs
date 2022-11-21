using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private IMovement _movement;

    private void Start()
    {
        _movement = new WalkMovement();
    }

    void FixedUpdate() //Вызывается независимо от FPS в игре, и 50 раз в секунду
    {
        float x = KeyboardInput.GetHorizontalDirection();
        float z = KeyboardInput.GetVerticalDirection();
        _movement.MoveToDirectionWithSpeed(gameObject, new Vector3(x, 0, z), _movementSpeed);
    }
}