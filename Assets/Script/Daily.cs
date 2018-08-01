using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class Daily : MonoBehaviour {






    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LogOut()
    {
        SceneManager.LoadScene("Login");
    }

    public void ChangeToUnion()
    {
        SceneManager.LoadScene("Union");
    }

    public void ChangeToSocial()
    {
        SceneManager.LoadScene("Social");
    }

    public void ChangeToFashion()
    {
        SceneManager.LoadScene("Fashion");
    }







}
