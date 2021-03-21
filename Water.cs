using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] float ArchimedForce;
    public GameObject respawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cat")
        {
            collision.gameObject.transform.position = respawn.transform.position;
            collision.gameObject.GetComponent<AudioSource>().Play();
        }
    }*/
    public void OnTriggerStay(Collider other)
    {
        //other.gameObject.transform.position = respawn.transform.position;
        //other.attachedRigidbody.AddForce(Vector3.up * ArchimedForce);
        //other.attachedRigidbody.drag = 2f;
        //other.gameObject.GetComponent<AudioSource>().Play();
    }
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = respawn.transform.position;
        other.gameObject.GetComponent<AudioSource>().Play();
        // if (check.gameObject.tag == "Cat")
        //other.gameObject.GetComponent<AudioSource>().Play();
    }
   
    public void OnTriggerExit(Collider other)
    {
        other.attachedRigidbody.drag = 0;
    }
}
