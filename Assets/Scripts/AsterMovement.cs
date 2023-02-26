using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsterMovement : MonoBehaviour
{
    Rigidbody physics;
    public float vel = 3f;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        physics.velocity = transform.forward * vel * -1f;
    }
}
