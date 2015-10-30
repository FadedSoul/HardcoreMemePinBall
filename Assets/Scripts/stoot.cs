using UnityEngine;
using System.Collections;

public class stoot : MonoBehaviour {
    private string _buttonName = "Jump";
    private Vector3 _forceDirection = Vector3.back;
    private bool _stopSign = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetButton(_buttonName))
        {
            GetComponent<Rigidbody>().AddForceAtPosition(_forceDirection.normalized * 80.0f, transform.position);
        }
        else /*if (_stopSign == false)*/
        {
            GetComponent<Rigidbody>().AddForceAtPosition(_forceDirection.normalized * -20000.0f, transform.position);
        }
    }
}