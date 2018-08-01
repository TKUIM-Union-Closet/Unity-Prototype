using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class RatingBar : MonoBehaviour {
	
	const string KEY_RATING_STARS = "rating-stars";
	public Image[] stars;	
	private int curRating;
    private string PanelName;


	
	[System.Serializable]
	public class RatingEvent : UnityEvent<int> {}
		
	public RatingEvent onRatingSet;
	
	// Use this for initialization
	void Start () {

        PanelName = this.name;
        //Debug.Log(PanelName);
		curRating = getRating();
		
		showStars(curRating);
		
		if(onRatingSet != null)
			onRatingSet.Invoke(curRating);
	}
	
	public void onStarCheck(int index){
		for(int i = 0; i < stars.Length; i++){
			if(stars[i] != null){
				stars[i].enabled = i <= index;					
			}
		}	
		
		
		int lastRating = curRating;
		curRating = index + 1;	
		setRating(curRating);
		
        if(onRatingSet != null){
            onRatingSet.Invoke(curRating);
            Debug.Log(PanelName+"説"+curRating+"分");
            /////////////////////
        }
			
		
	}	
	
	public void setRating(int rating){
		PlayerPrefs.SetInt(KEY_RATING_STARS, rating);
	}
	
	public int getRating(){
		return PlayerPrefs.GetInt(KEY_RATING_STARS, 0);
	}
	
	private void showStars(int rating){
		for(int i = 0; i < stars.Length; i++){
			if(i < rating && stars[i] != null)
				stars[i].enabled = true;
		}
	}
}
