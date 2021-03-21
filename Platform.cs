using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody _platformRigidbody;
    float _targetY = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //_platformRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovingPlatform();
    }
    public void MovingPlatform()
    {
        Vector3 _targetPosition = new Vector3(transform.position.x, _targetY, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, 0.01f);

        if (transform.position == _targetPosition && _targetPosition.y != 0.3f)
            _targetY = 0.3f;
        if (transform.position == _targetPosition && _targetPosition.y != 1.0f)
            _targetY = 1.0f;

    }
}
