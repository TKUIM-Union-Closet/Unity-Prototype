using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FeedbackControl : MonoBehaviour {

    public Text titleText;
    public Text Text;

	// Use this for initialization
	void Start () {
	
	}
	
	public void onRatingSet(int rating){
        if(titleText != null){
            titleText.text = "您的評分為 " + rating + " 分！";

        }
			
        
	}
	
}
