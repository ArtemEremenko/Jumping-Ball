using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCoin : MonoBehaviour
{
    [Tooltip("Turn per second"), SerializeField] private float _angularSpeed = 0;

    private void Update()
    {
        transform.Rotate(Vector3.forward, _angularSpeed * 360f * Time.deltaTime);
    }
}
