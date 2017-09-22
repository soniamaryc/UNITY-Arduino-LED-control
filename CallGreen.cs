using UnityEngine;
using System.Collections;


public class CallGreen : MonoBehaviour {

	private LEDColor colorscript;
	public GameObject LEDs;

	void Awake () {

		colorscript = LEDs.GetComponent<LEDColor>();

			}

	// Update is called once per frame
	void Update () {
	
	}

	 void OnMouseDown() {
	 	print("Clicked");

		colorscript.sendGreen ();
	 	//Sending.sendGreen();
	 }
}
