using UnityEngine;
using System.Collections;

public class Flippers : MonoBehaviour {
    [SerializeField]
	private float _force = 100.0f;
    [SerializeField]
    private Vector3 _forceDirection = Vector3.forward;
    [SerializeField]
    private string buttonName = "Fire1";
    [SerializeField]
    private Vector3 _offset;
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButton(buttonName))
		{
			GetComponent<Rigidbody>().AddForceAtPosition(_forceDirection.normalized*_force,transform.position+_offset);
		}
		else
		{
			GetComponent<Rigidbody>().AddForceAtPosition(_forceDirection.normalized*-_force,transform.position+_offset);
		}
	}
}
