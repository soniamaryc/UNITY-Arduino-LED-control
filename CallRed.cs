using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CallRed : MonoBehaviour {


	private LEDColor colorscript;

	public GameObject LEDs;

	void Awake () {
	
		colorscript = LEDs.GetComponent<LEDColor>();


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// To do: Change the code to mobile touch

	void OnMouseDown() {
	 	print("Clicked");
		colorscript.sendRed ();

	 }


}//class


