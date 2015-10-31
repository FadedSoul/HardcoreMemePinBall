using UnityEngine;
using System.Collections;

public class CamTrigger : MonoBehaviour {
    [SerializeField]
    private Camera Cam;
    private bool _Cam;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if(_Cam == true)
            {
                _Cam = false;
            }
            else
            {
                _Cam = true;
            }
        }
    }
}
