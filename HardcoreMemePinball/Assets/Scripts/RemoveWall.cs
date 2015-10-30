using UnityEngine;
using System.Collections;

public class RemoveWall : MonoBehaviour{

    //private Score score;
    [SerializeField]
    private Score score;
	// Use this for initialization
    void Start()
    {
     
    }
	
	// Update is called once per frame
    void Update()
    {
        if (score.PlayerScore > 100)
        {
            Destroy(gameObject);
        }
    }
}
