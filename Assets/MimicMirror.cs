using UnityEngine;
using System.Collections;

public class MimicMirror : MonoBehaviour {

	public GameObject followedObject;

    // Use this for initialization
    void Start () {
		transform.parent = followedObject.transform;
    }

	void followPosition() {
        Vector3 _tmp = followedObject.transform.position;
        _tmp.x = followedObject.transform.position.x;
        _tmp.y = 0; //followedObject.transform.position.y;
        _tmp.z = 0; //followedObject.transform.position.z;
		this.transform.position = _tmp; 
	}
    void followRotation()
    {
        Vector3 _tmp2 = followedObject.transform.eulerAngles;
        _tmp2.x = 0;
        _tmp2.y = 0; 
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
