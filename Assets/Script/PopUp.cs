using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour {

    public static PopUp instance;

	// Use this for initialization
	void Start () {

        instance = this;

        Shaded();
		
	}

    public CanvasGroup CanvasChange;

    public void Awake()
    {
        CanvasChange = GetComponent<CanvasGroup>();
    }

    public void Popup()
    {
        CanvasChange.alpha = 1f;
        CanvasChange.interactable = true;
        CanvasChange.blocksRaycasts = true;

    }

    public void Shaded(){
        CanvasChange.alpha = 0f;
        CanvasChange.interactable = false;
        CanvasChange.blocksRaycasts = false;
    }


}
