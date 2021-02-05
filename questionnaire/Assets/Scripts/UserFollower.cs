using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserFollower : MonoBehaviour {
    public GameObject User;

    void Start() {
        
    }

    void Update() {
        var newPos = User.transform.position + User.transform.forward * 0.4f;
        transform.position = Vector3.Lerp(transform.position, newPos, 0.05f);

        var toUser = User.transform.position - transform.position;
        //toUser = Vector3.ProjectOnPlane(toUser, Vector3.up).normalized;
        transform.rotation = Quaternion.LookRotation(toUser);       
    }
}
