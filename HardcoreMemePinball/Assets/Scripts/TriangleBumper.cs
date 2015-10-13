using UnityEngine;
using System.Collections;

public class TriangleBumper : MonoBehaviour
{
	public float force = 100.0f;
	
	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Rigidbody>() != null)
		{
			col.GetComponent<Rigidbody>().AddForce(transform.forward*force);
		}
	}
}
