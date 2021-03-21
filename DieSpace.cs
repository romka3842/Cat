using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpace : MonoBehaviour
{
    public GameObject respawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cat")
        {
            collision.gameObject.transform.position = respawn.transform.position;
            collision.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
