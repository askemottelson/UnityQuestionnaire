using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FingerTip : MonoBehaviour
{
    public OVRHand Hand;
    private OVRSkeleton skeleton;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        skeleton = Hand.GetComponent<OVRSkeleton>();
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            var tipPos = skeleton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.position;
            this.transform.position = tipPos;
        }
        catch (Exception e)
        {

        }
    }
}