using UnityEngine;
using System.Collections;

public class GoMenu : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
        }
    }
}
