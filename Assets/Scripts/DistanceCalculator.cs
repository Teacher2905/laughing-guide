using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] public float Distance { get; private set; }

    private void Update()
    {
        if (_target != null)
            Distance = (_target.position - transform.position).magnitude;
    }
}