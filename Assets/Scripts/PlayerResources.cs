using UnityEngine;

public class PlayerResources : MonoBehaviour
{
    public float _money;
    private bool _isKeyPressed;

    public void BuyMachine(MachineFactory factory)
    {
        if (_money >= factory.MachinePrice)
        {
            _money -= factory.MachinePrice;
            factory.Create();
        }
    }

    private void Update()
    {
        _isKeyPressed = Input.GetKeyDown(KeyCode.E);
        Debug.Log(_money);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (_isKeyPressed && collision.gameObject.tag == "Buyzone")
        {
            collision.gameObject.GetComponent<MachineFactory>().Create();
        }
    }
}
