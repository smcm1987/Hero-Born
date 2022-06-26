using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    private float _vInput;
    private float _hInput;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        //this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        //this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
        
    }

    //all physics or RigidBody-related code goes inside the FixedUpdate method
    //frame rate independent and used for physics code
    void FixedUpdate()
    {
        //store left and right rotation
        Vector3 rotation = Vector3.up * _hInput;

        //takes a Vector 3 parameter (rotation) and returns rotation value in Euler angles
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        //MovePosition takes in Vector 3 parameter and applies force
        _rigidbody.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rigidbody.MoveRotation(_rigidbody.rotation * angleRot);
    }
}
