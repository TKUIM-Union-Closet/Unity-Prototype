using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class Client : MonoBehaviour
{
    private ClientThread ct;
    private bool isSend;
    private bool isReceive;
    private int count = 0;
    private System.String str;

    private void Start()
    {
        ct = new ClientThread(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp, "163.13.201.90", 36002);
        ct.StartConnect();
        isSend = true;
    }

    private void Update()
    {
        if (ct.receiveMessage != null)
        {
            GameObject.Find("Canvas/Textbox").GetComponent<UnityEngine.UI.Text>().text = "Server:" + ct.receiveMessage;
            Debug.Log("Server:" + ct.receiveMessage);
            ct.receiveMessage = null;
        }
        if (isSend == true)
            StartCoroutine(delaySend());

        ct.Receive();
    }

    private IEnumerator delaySend()
    {
        //str = count.ToString();
        isSend = false;
        yield return new WaitForSeconds(1);
        ct.Send("1,1,1,1");
        Debug.Log("sented");

        //ct.Send(str);

        //count++;

        isSend = true;
    }

    private void OnApplicationQuit()
    {
        ct.StopConnect();
    }
}