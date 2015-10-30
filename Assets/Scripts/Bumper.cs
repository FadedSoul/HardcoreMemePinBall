using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {
    [SerializeField]
    private float _Force = 100.0f;
    [SerializeField]
    private float _ForceRadius = 1.0f;
	[SerializeField]
	private Score score;
	[SerializeField]
	private int _GainScore = 10;

	void OnCollisionEnter()
	{

		foreach(Collider col in Physics.OverlapSphere(transform.position, _ForceRadius))
		{
			if(col.GetComponent<Rigidbody>())
			{
				col.GetComponent<Rigidbody>().AddExplosionForce(_Force,transform.position,_ForceRadius);
				score.PlayerScore += _GainScore;
				score.SetScoreText();
			}
		}
	}
}
