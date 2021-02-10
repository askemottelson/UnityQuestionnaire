using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserFollower : MonoBehaviour {
    public GameObject User;
    private float step = 0.5f;
    private float e = 1.0f * 0.0001f;

    void Start() {
        
    }

    void OnEnable()
    {
        // enable move
        step = 0.05f;
    }

    void decreaseStep()
    {
        step = step - e;
    }

    void Update() {
        decreaseStep();

        var newPos = User.transform.position + User.transform.forward * 0.4f;
        transform.position = Vector3.Lerp(transform.position, newPos, step);

        var toUser = User.transform.position - transform.position;
        //toUser = Vector3.ProjectOnPlane(toUser, Vector3.up).normalized;
        transform.rotation = Quaternion.LookRotation(toUser);       
    }
}
