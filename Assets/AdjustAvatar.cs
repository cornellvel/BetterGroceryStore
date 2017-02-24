using UnityEngine;
using System.Collections;

public class AdjustAvatar : MonoBehaviour {

    public GameObject CameraRig;
    public GameObject Avatar;

    // Use this for initialization
    void Start()
    {
        
        Avatar.transform.position = new Vector3((CameraRig.transform.position.x +3f), CameraRig.transform.position.y + 2f, CameraRig.transform.position.z);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
