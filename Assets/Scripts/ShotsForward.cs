using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotsForward : MonoBehaviour
{
    Rigidbody Rig;
    public float vel = 15f;
    void Start()
    {
        Rig = GetComponent<Rigidbody>();
        Rig.velocity = transform.forward * vel;
    }

}