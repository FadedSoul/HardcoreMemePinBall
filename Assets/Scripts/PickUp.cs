using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	[SerializeField]
	private GameObject _player;
	[SerializeField]
	private GameObject _PickUpManager;
	private float _scale = 1.25f;

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player") 
		{
			if(this.gameObject.tag == "Scale")
			{	
				this.gameObject.transform.position -= new Vector3(0,1,0);
				_player.transform.localScale = new Vector3 (_scale, _scale, _scale);				
		   		StartCoroutine(PickUpScaleTimeOut());
			}
			if(this.gameObject.tag == "Multiply")
			{
				this.gameObject.transform.position -= new Vector3(0,1,0);
				Instantiate(_player, new Vector3(1.3f, 1.75f, -4.5f), Quaternion.Euler(0, 180, 0));
				StartCoroutine(PickUpMultiplyTimeOut());
			}
		}
		
	}

	IEnumerator PickUpScaleTimeOut()
	{
		yield return new WaitForSeconds(10);
		_player.transform.localScale = new Vector3(1,1,1);
		Destroy(this.gameObject);

	}
	IEnumerator PickUpMultiplyTimeOut()
	{
		yield return new WaitForSeconds(10);
		Destroy(GameObject.Find("Player(Clone)"));
		Destroy(this.gameObject);
		
	}
}
