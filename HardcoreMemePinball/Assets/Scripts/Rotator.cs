using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	void Update()
	{
		transform.Rotate(new Vector3(1.5f,3.0f,4.5f * Time.deltaTime));
	}
}
