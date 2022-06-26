using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    //declares vector to store the distance between the main camera and the player
    public Vector3 CamOffset = new Vector3(0f, 1.2f, -2.6f);

    //access to the player capsule's transform information.
    //private access modifier ensures no one else can change target via script
    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        //use .Find to lcate the player capsule and retrieve its transform properties
        //computationally expensive, best to do once at Start
        _target = GameObject.Find("Player").transform;
    }

    // Updates after Update() is called
    //Done because the player movement is done during Update()
    void LateUpdate()
    {
        //returns a relative position of target in the world space
        this.transform.position = _target.TransformPoint(CamOffset);

        //updates the capsule's rotation every frame, focusing on the Transform parameter set (_target)
        this.transform.LookAt(_target);
    }
}
