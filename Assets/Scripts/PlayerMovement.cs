using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rig;
    public float rotate = 5f;
    private float horizontal;
    private float vertical;
    public float speed = 5f;

    float shottime=0;

    public GameObject shot;
    public Transform shotsOut;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > shottime)
        {
            shottime = Time.time + 0.5f;
            Instantiate(shot, shotsOut.position,Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical= Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        rig.velocity = movement * speed;
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, -3.33f, 3.33f), 0.0f, Mathf.Clamp(rig.position.z, 0f, 7.45f));
        rig.rotation = Quaternion.Euler(0, 0, rig.velocity.x * -rotate);

    }
}
