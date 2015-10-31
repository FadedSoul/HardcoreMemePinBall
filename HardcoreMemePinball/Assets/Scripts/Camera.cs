using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    private bool _Cam = true;
	// Use this for initialization
    public bool Cam
    {
        get { return _Cam; }
        set { _Cam = value; }
    }
	void Start () {
        transform.position = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    if(_Cam)
        {
            this.gameObject.transform.position = new Vector3(0, 22, -32);
            
        }
        else
        {
            this.gameObject.transform.position = new Vector3(0, 22, 8);
        }
	}
}
