using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    private bool _onGround;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Jump();
    }

    private void Jump()
    {
        if (KeyboardInput.IsJumpPressed() && _onGround)
        {
            _rigidbody.AddForce(new Vector3(0, _jumpForce, _jumpForce));
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            _onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _onGround = false;
    }
}
