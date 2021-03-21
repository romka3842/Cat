using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    [SerializeField] float _speed = 10.0f;
    [SerializeField] float _jumpSpeed = 5.0f;
    [SerializeField] List <GameObject> Lifes;
    protected Rigidbody _rigidbody;
    protected Animator _catAnimator;
    protected AudioSource _meowSound;
    Camera _mainCamera;
    public bool _onGround;
    public Transform _groundCheck;
    public LayerMask Ground;
    public Joystick _joystick;
    protected int lifes = 8;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _meowSound = GetComponent<AudioSource>();
        _mainCamera = GetComponent<Camera>();
        _catAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //MovingCatTransform();       
        MobileMove();
    }
    void Update()
    {
        //CatAnimation();
        //Jump();

    }
    public void OnCollisionStay (Collision collision)
    {

        if (collision.gameObject.tag == "Platform")
        {
            print(collision.gameObject.name);
            print("Collision!");
            _onGround = true;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            print("Air");
            _onGround = false;
        }
    }
    public void MovingCatPhysics()
    {
        float MoveCat = Input.GetAxis("Horizontal") * _speed;
        _rigidbody.AddForce(new Vector3(MoveCat,0,0));
      
    }
    public void MovingCatTransform()
    {
        float MoveCat = Input.GetAxis("Horizontal") * _speed;
        Vector3 forward = Vector3.zero;
        Vector3 back = new Vector3(0, -180, 0);
        transform.position =transform.position + transform.forward * (-MoveCat);
        /*
        if (Input.GetAxis("Horizontal") == 1.0f)
        {
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, forward, Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") == -1.0f)
        {
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, back, Time.deltaTime);
        }
        */
    }
    public void MobileMove()
    {
        float MoveCat = _joystick.Horizontal * _speed;
        Vector3 forward = Vector3.zero;
        Vector3 back = new Vector3(0, -180, 0);
        transform.position = transform.position + transform.forward * (-MoveCat);
        if (_joystick.Horizontal == 0)
        {
            _catAnimator.SetBool("Walk", false);
        }
        if (_joystick.Horizontal != 0)
        {
            _catAnimator.SetBool("Walk", true);
        }
    }

    public void Jump()
    {        
        if (Input.GetKeyDown(KeyCode.Space) && _onGround == true)
        {
            _rigidbody.AddForce(Vector3.up * _jumpSpeed );
            //_meowSound.Play();
            //print("Пробел");
        }
    }
    public void MobileJump()
    {
        if (_onGround == true)
        {
            _rigidbody.AddForce(Vector3.up * _jumpSpeed);
            _catAnimator.SetBool("Jump", true);
        }
    }
    public void MobileJumpFalse()
    {
        if (_onGround == false)
        {
            _catAnimator.SetBool("Jump", false);
        }
    }
    public void CatAnimationKeyBoard()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _catAnimator.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _catAnimator.SetBool("Walk", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _catAnimator.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            _catAnimator.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && _onGround == true)
        {
            _catAnimator.SetBool("Jump", true);           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _catAnimator.SetBool("Jump", false);
        }
    }
}
