﻿using UnityEngine;
using System.Collections;

public class MimicHipsFemale : MonoBehaviour
{

    public GameObject followedObject;
    public GameObject holdHeight;
    public float theHeight;

    // Use this for initialization
    void Start()
    {
        transform.parent = followedObject.transform;
        theHeight = holdHeight.transform.position.y;
        Debug.Log(theHeight);
    }

    void followPosition()
    {
        Vector3 _tmp = followedObject.transform.position;
        _tmp.x = (followedObject.transform.position.x - .14f);
        _tmp.y = (followedObject.transform.position.y - (theHeight * .35f) + .0142f);
        //_tmp.y = followedObject.transform.position.y - (theHeight * .35f);
        //_tmp.y = 0;
        _tmp.z = followedObject.transform.position.z;
        this.transform.position = _tmp;
    }
    void followRotation()
    {
        Vector3 _tmp2 = followedObject.transform.eulerAngles;
        _tmp2.x = 0;
        //The body turns as a percentage of the head turning
        _tmp2.y = followedObject.transform.eulerAngles.y;
        //_tmp2.y = (followedObject.transform.eulerAngles.y * .75f);
        _tmp2.z = 0;
        this.transform.eulerAngles = _tmp2;
    }
    // Update is called once per frame

    void Update()
    {
        followPosition();
        followRotation();
    }
}