using UnityEngine;
using System.Collections;

public class FlatBumper : MonoBehaviour
{
    [SerializeField]
	private float _force = 1000.0f;
    [SerializeField]
    private Score score;
    [SerializeField]
    private int _GainScore = 10;
	
	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Rigidbody>() != null)
		{
			col.GetComponent<Rigidbody>().AddForce(transform.forward*_force);
            score.PlayerScore += _GainScore;
            score.SetScoreText();
		}
	}
}
