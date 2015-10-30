using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetAll : MonoBehaviour
{


    public Text myText;
    // Use this for initialization
    void Start()
    {
        string url = "http://18419.hosts.ma-cloud.nl/bewijzenmap/periode1/Pro/Dunj/High/Unity.php";


        WWW www = new WWW(url);

        StartCoroutine(WaitForRequest(www, true));
    }

    IEnumerator WaitForRequest(WWW www, bool Phrase)
    {

        yield return www;

        if (Phrase) PhraseString(www.text);
        // check for errors

        if (www.error == null)
        {
            Debug.Log(www.text);
            //countText.text = www.text;
        }
        else
        {
            Debug.Log(www.error);
        }
    }

    void PhraseString(string inText)
    {

        string[] myStr = inText.Split(' ');

        foreach (string text in myStr)
        {

            myText.text += text + " ";

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
