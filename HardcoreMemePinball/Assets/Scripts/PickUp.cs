using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	[SerializeField]
	private GameObject _player;
	private float _scale = 1.25f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			this.gameObject.transform.position -= new Vector3(0,1,0);
			_player.transform.localScale = new Vector3 (_scale, _scale, _scale);
		   	StartCoroutine(PickUpTimeOut());
		}
		
	}

	IEnumerator PickUpTimeOut()
	{
		yield return new WaitForSeconds(10);
		_player.transform.localScale = new Vector3(1,1,1);
		Destroy(this.gameObject);
	}
}
