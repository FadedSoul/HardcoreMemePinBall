using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log (col.transform.tag);
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("LoseScreen");
            //Debug.Log(col.gameObject.tag == "Player");
        }
    }
}
