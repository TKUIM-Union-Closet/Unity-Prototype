using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.Sockets;
using UnityEngine.UI;
using System;

public class Login : MonoBehaviour {


    private SocketThread ct;
    private bool isSend;
    private bool isReceive;
    //private int count = 0;
    private System.String str;
    public Text ClientID;
    public Text Password;
    public Text LoginError;
    public string LoginString;
    public int user;

    

	// Use this for initialization
	void Start () {

        ct = new SocketThread(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp, "163.13.201.90", 36001);
        ct.StartConnect();
        isSend = true;
        LoginError = GameObject.Find("LoginError").GetComponent<Text>();
        //LoginError.gameObject.SetActive(false);
        LoginError.enabled = false;
	}
	

    public void ChangeToSignUp ()
    {
        SceneManager.LoadScene("Signup");

    }

    public void ChangeToDaily(){
        SceneManager.LoadScene("DailyBoy");
    }


    public void LoginClick ()
    {
        if (isSend == true)
        {

            StartCoroutine(delaySend());

        }





    }

    private void Update()
    {

        ct.Receive();
        String[] Message =  ct.receiveMessage.Split('/');


        if (Message[0] == "yes")
        {
            //GameObject.Find("Canvas/Textbox").GetComponent<UnityEngine.UI.Text>().text = "Client:" + ct.receiveMessage;
            Debug.Log("Server:" + ct.receiveMessage);
            Debug.Log("Change");

            Debug.Log(Message[1]);

            if (Message[1] == "liao"){
                SceneManager.LoadScene("DailyBoy");
            } else if (Message[1] == "ling"){
                SceneManager.LoadScene("DailyGirl");
            } else if (Message[1] == "asdzxc"){
                SceneManager.LoadScene("DailyBoy");
            } 


            ct.receiveMessage = null;

        } else if (Message[0] == "no"){

            LoginError.enabled = true;
            Debug.Log("Server:" + ct.receiveMessage);

            ct.receiveMessage = null;

        } 

        
    }


    public IEnumerator delaySend()
    {
        //str = count.ToString();
        EnterID();
        isSend = false;
        yield return new WaitForSeconds(0);
        //ct.Send("1,1,1");
        ct.Send(LoginString);
        //ct.Send(str);
        //Debug.Log("send   " + LoginString);
        //count++;

        isSend = true;
    }


    private void OnApplicationQuit()
    {
        ct.StopConnect();
    }

    public void EnterID(){

        //ClientID.text = enterText.text;
        //Password.text = enterPassword.text;
        LoginString = ClientID.text + "/" + GameObject.Find("InputPassword").GetComponent<InputField>().text;


    }

   
}
