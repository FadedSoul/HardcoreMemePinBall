using UnityEngine;
using System.Collections;

public class PickUpManager : MonoBehaviour {
	[SerializeField]
	private GameObject _PickUpScale;
	[SerializeField]
	private GameObject _PickUpMultiply;
	private bool ActivePickUp = true;
	private int _randomPick;
	private Vector3 _ManagerPos;
	
	void Awake()
	{
		_ManagerPos = this.transform.position;
	}

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
			
			if(_randomPick == 1)
			{
				ActivePickUp = true;
				_PickUpMultiply.transform.position = _ManagerPos;
			}

			else if(_randomPick == 2)
			{
				ActivePickUp = true;
				_PickUpScale.transform.position = _ManagerPos;
			}
		}
	}
}