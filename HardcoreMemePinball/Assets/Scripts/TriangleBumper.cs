using UnityEngine;
using System.Collections;

public class TriangleBumper : MonoBehaviour
{
	private float _force = 300.0f;
	
	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Rigidbody>() != null)
		{
			col.GetComponent<Rigidbody>().AddForce(transform.forward*_force);
		}
	}
}
