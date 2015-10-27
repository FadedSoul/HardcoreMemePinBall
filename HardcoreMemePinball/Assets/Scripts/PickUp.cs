using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	[SerializeField]
	private GameObject _player;
	private float _scale = 1.5f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (this.tag == "ScalePickUp") 
		{
			if (other.gameObject.tag == "Player") 
			{
				_player.transform.localScale = new Vector3 (_scale, _scale, _scale);
				Destroy (this.gameObject);
			}
		}
	}
}
