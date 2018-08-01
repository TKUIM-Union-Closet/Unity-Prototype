#if UNITY_EDITOR

using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;

public class ScreenDumper : MonoBehaviour {


	public string dumpFolder = "capture";
	public string filePrefix = "cap-";
	public bool capture;
	public int frameRate = 5;
	public int startDelayMS = 1000;
	
	private int skipInitialFrames, count;
	private int interval, capCount;

	// Use this for initialization
	void Start () {
		Directory.CreateDirectory(dumpFolder);
			
		float fps = 1 / Time.deltaTime;
		
		skipInitialFrames = (int)((fps * startDelayMS)/1000);
		
		interval = (int)(fps / frameRate);
		print ("fps = " + fps + ", interval = " + interval + ", skip frames = " + skipInitialFrames);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(capture){
			count++;
			if(count > skipInitialFrames){
				if(count % interval == 0){
					//print ("Capture " + count);
					capCount++;
					ScreenCapture.CaptureScreenshot(dumpFolder + "/" + filePrefix + capCount + ".png");
				}
			}
		}else{
			count = 0;
		}
	}

}
#endif