using UnityEngine;
using System.Collections;

public class CamTrigger : MonoBehaviour {
    [SerializeField]
    private MainCam getCam;
    void start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log(getCam.Cam);
            if(getCam.Cam == true)
            {
                getCam.Cam = false;
            }
            else
            {
                getCam.Cam = true;
            }
        }
    }
}
