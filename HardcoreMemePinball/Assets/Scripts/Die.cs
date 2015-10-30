using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Die : MonoBehaviour {
	private int _Lives = 3;
	[SerializeField]
	private Text _LivesText;
	void Start()
	{
		SetLives();
	}

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player" && _Lives > 1)
        {
			_Lives--;
			SetLives();
		}
		else
		{
			Application.LoadLevel("LoseScreen");
		}
    }
	void SetLives()
	{
		_LivesText.text = "Lives: " + _Lives.ToString();
	}

}
