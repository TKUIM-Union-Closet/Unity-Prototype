using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeUppon : MonoBehaviour
{
    public string name;

    void Start()
    {

        name = this.gameObject.name;
        
    }

    public void Boy()
    {
        
        ChangeBoy.instance.Changecloth(name);
        PopUp.instance.Shaded();

    }

    public void Girl(){

        ChangeFoot.instance.Changecloth(name);
        PopUp.instance.Shaded();
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}