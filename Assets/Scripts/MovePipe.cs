using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
