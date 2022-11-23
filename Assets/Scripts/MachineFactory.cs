using UnityEngine;

public class MachineFactory : MonoBehaviour
{
    [SerializeField] private GameObject _cashmachinePrefab;
    private bool _isCanCreateMachine = true;

    public int MachinePrice { get; } = 100;

    public void Create()
    {
        if(_isCanCreateMachine)
        {
            Instantiate(_cashmachinePrefab, transform.position, Quaternion.identity, null);
            _isCanCreateMachine = false;
        }
    }
}
