using UnityEngine;

public static class KeyboardInput
{
    public static float GetHorizontalDirection()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public static float GetVerticalDirection()
    {
        return Input.GetAxisRaw("Vertical");
    }

    public static bool IsJumpPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}