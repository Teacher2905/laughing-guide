using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private IMovement _movement;

    private void Start()
    {
        _movement = new WalkMovement();
    }

    void Update() //Вызывается раз в кадр (60 раз в секунду)
    {
        if (Input.GetKey(KeyCode.D))    
            _movement.MoveToDirectionWithSpeed(gameObject, Vector3.right, _movementSpeed);
        else if (Input.GetKey(KeyCode.A))
            _movement.MoveToDirectionWithSpeed(gameObject, Vector3.left, _movementSpeed);
        if (Input.GetKey(KeyCode.W))
            _movement.MoveToDirectionWithSpeed(gameObject, Vector3.forward, _movementSpeed);
        else if (Input.GetKey(KeyCode.S))
            _movement.MoveToDirectionWithSpeed(gameObject, Vector3.back, _movementSpeed);
    }
}
