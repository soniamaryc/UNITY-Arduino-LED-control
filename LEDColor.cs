
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TechTweaking.Bluetooth;
public class LEDColor : MonoBehaviour

{

    private BluetoothDevice device;
    public Text statusText;
    private static readonly object msg1;
	//public Text dataToSend;

	void Awake () {

		BluetoothAdapter.enableBluetooth();//Force Enabling Bluetooth
		device = new BluetoothDevice();
		device.Name = "HC-05";
		device.setEndByte (10);
    	device.ReadingCoroutine = ManageConnection;

	}

   
    public void connect()
    {
        statusText.text = "Status : ...";
		device.connect();
		//statusText.text = "Status : Connected ";

    }

    public void disconnect()
    {
        device.close();
	  //statusText.text = "Status : Disconnected ";

    }




    //############### Reading Data  #####################
     //Please note that you don't have to use this Couroutienes/IEnumerator, you can just put your code in the Update() method
     IEnumerator ManageConnection(BluetoothDevice device)
     {
         statusText.text = "Status : Connected & Can read";

         while (device.IsReading)
         {
             if (device.IsDataAvailable)
             {
                 byte[] msg = device.read();//because we called setEndByte(10)..read will always return a packet excluding the last byte 10.

                 if (msg != null && msg.Length > 0)
                 {
                     string content = System.Text.ASCIIEncoding.ASCII.GetString(msg);
                     statusText.text = "MSG : " + content;
                 }
             }

             yield return null;
         }

         statusText.text = "Status : Done Reading";

     }


	void OnApplicationQuit() 
	{
		disconnect ();
	}


	public void sendRed ()
		{


			//device.send (new byte [] { 1} );
		string red = "1";
		device.send (System.Text.Encoding.ASCII.GetBytes(red));


		}

	public void sendYellow ()
		{

		string yellow = "2";
			//device.send (new byte [] { 2 });
		device.send (System.Text.Encoding.ASCII.GetBytes(yellow));
		}

	public void sendGreen()
		{
		string green = "3";
		device.send (System.Text.Encoding.ASCII.GetBytes(green));
	}


}//Class




