using UnityEngine;
using System.Collections;

public class PickUpManager : MonoBehaviour {
	[SerializeField]
	private GameObject _PickUpScale;
	[SerializeField]
	private GameObject _PickUpMultiply;
	private bool ActivePickUp = true;
	private int _randomPick;
	

	void OnTriggerEnter(Collider other)
	{

		if(other.gameObject.tag == "Scale" || other.gameObject.tag == "Multiply")
		{
			ActivePickUp = true;
		}
		else
		{
			ActivePickUp = false;
			StartCoroutine(PickUpCoolDown());
		}

	}

	IEnumerator PickUpCoolDown()
	{
		yield return new WaitForSeconds(10);
		if(ActivePickUp == false)
		{
			_randomPick = Random.Range(1,3);
			Debug.Log(_randomPick);
			if(_randomPick == 1)
			{
				_PickUpMultiply.transform.position += new Vector3(0,2,0);
				ActivePickUp = true;
			}
			else if(_randomPick == 2)
			{
				_PickUpScale.transform.position += new Vector3(0,2,0);
				ActivePickUp = true;
			}
		}
	}
}
