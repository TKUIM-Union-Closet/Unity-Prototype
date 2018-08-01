using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Union : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeToDailyGirl()
    {
        SceneManager.LoadScene("DailyGirl");
    }

    public void ChangeToSocial()
    {
        SceneManager.LoadScene("Social");
    }

    public void ChangeToFashion()
    {
        SceneManager.LoadScene("Fashion");
    }

    public void ChangeToOtherCatalog(){
        SceneManager.LoadScene("OtherCatalog");
    }
}
