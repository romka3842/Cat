using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody.AddRelativeTorque(new Vector3(0, 0, 0.1f),ForceMode.VelocityChange);
        //transform.Rotate(new Vector3(0, 0, 1f));
        transform.RotateAroundLocal(Vector3.up, 0.03f);
    }
}
