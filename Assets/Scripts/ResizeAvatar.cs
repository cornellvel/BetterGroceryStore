using UnityEngine;
using System.Collections;

public class ResizeAvatar : MonoBehaviour {

    public GameObject holdHeight;

    // Use this for initialization
    void Start () {
        float theHeight = holdHeight.transform.position.y;
        float percentage = (theHeight/1.56f);
        Vector3 _tmp = this.transform.localScale;
        //percentage of the avatar height
        _tmp.x = (this.transform.localScale.x * percentage);
        _tmp.y = (this.transform.localScale.y * percentage);
        _tmp.z = (this.transform.localScale.z * percentage);
        this.transform.localScale = _tmp;
    }
}
