using UnityEngine;
using System.Collections;
using System.Security;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
	private string postURL = "http://localhost/HighScores/index.php";
    private string getURL = "http://localhost/HighScores/index.php";
	public Text text;
	private bool parse;
	private string _name = "";
	private string score = "";
	private int highscore = 0;

	private int count = 0;
	List<string> scoreList = new List<string>();
	List<string> nameList = new List<string>();

	// Use this for initialization
	void Start () {
		OnGUI();
	}
	
	public void OnGUI(){
        
		GUI.Label(new Rect( 10, 10, 50, 25), "Name");
		_name = GUI.TextField(new Rect( 70, 10, 100, 25), _name);
		
		if(GUI.Button(new Rect( 180, 10, 80, 25), "Send Name"))
			StartCoroutine( "SaveData" );
		
		if(GUI.Button(new Rect( 10, 80, 80, 25), "Get Name"))
			StartCoroutine( "LoadData" );
		
		if(GUI.Button(new Rect( 10, 120, 80, 25), "Add Score"))
			StartCoroutine( "Score" );
         
	}
	
	void Score(){
		highscore = highscore + 1;
		//highscore.ToString(score);
		Debug.Log(highscore);

	}

	private IEnumerator LoadData(){
		Debug.Log("Getting name from " + getURL);
		WWW getName = new WWW(getURL);
		
		yield return getName;
	
		Debug.Log(getName.text);
	}


	private IEnumerator SaveData(){
		string urlString = postURL + "?name=" + WWW.EscapeURL(_name) + "&score=" + WWW.EscapeURL(highscore.ToString(score)) + " " ;
		Debug.Log( "Sending: " + urlString);
		WWW postName = new WWW(urlString);
		yield return postName;

		text.text = "HighScore" + "\n" + postName.text + "\n";
		Debug.Log(postName.text + '\n');
		                  
	}

	void parseString(string postName){
		string[] myStr = postName.Trim().Split('\n');
		if (postName == string.Empty){
			return;
			count = 0;
		}
		foreach (string entry in myStr)
		{
			if(!entry.Contains("\t")){
				print("Data not OK: " + entry);
			}
			string[] temp = entry.Split('\n');
			nameList.Add(temp[0]);
			scoreList.Add(temp[1]);
			count++;
			Debug.Log(entry);

		}
	}

}