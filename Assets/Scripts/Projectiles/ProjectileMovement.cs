using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    [SerializeField] private float speed = 8;
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
