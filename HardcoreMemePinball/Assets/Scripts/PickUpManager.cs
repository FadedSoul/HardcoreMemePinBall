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
		yield return new WaitForSeconds(20);
		if(ActivePickUp == false)
		{
			_randomPick = Random.Range(1,3);
			Debug.Log(_randomPick);
			if(_randomPick == 1)
			{
				Instantiate(_PickUpMultiply);
				ActivePickUp = true;
			}
			else if(_randomPick == 2)
			{
				Instantiate(_PickUpScale);
				ActivePickUp = true;
			}
		}
	}
}
