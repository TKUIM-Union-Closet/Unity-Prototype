using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Social : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeToDaily()
    {
        SceneManager.LoadScene("Daily");
    }

    public void ChangeToUnion()
    {
        SceneManager.LoadScene("Union");
    }

    public void ChangeToFashion()
    {
        SceneManager.LoadScene("Fashion");

    }


}
