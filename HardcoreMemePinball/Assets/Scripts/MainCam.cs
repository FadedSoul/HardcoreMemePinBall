using UnityEngine;
using System.Collections;

public class MainCam : MonoBehaviour {

    private bool _Cam;
	
    public bool Cam
    {
        get { return _Cam; }
        set { _Cam = value; }
    }
	void Start () {
        _Cam = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if(_Cam == true)
        {
            this.gameObject.transform.position = new Vector3(0, 22, -32);
            
        }
        else
        {
            this.gameObject.transform.position = new Vector3(0, 22, 8);
        }
	}
}
