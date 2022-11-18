using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _offsetZ, _offsetY;

    private void LateUpdate()
    {
        Vector3 playerPosition = _player.transform.position;
        transform.position = new Vector3(playerPosition.x, playerPosition.y + _offsetY, playerPosition.z + _offsetZ);
    }
}