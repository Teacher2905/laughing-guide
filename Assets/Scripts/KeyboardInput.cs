using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        Debug.Log(horizontal);
    }
}