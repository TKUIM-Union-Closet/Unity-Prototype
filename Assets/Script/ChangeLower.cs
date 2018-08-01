using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLower: MonoBehaviour
{
    public string name;

    void Start()
    {
        name = this.gameObject.name;
    }
    
    public void Boy()
    {
        
        ChangeBoy.instance.ChangeFeet(name);
        PopUp.instance.Shaded();
    }

    
    // Update is called once per frame
    public void Girl()
    {
        ChangeFoot.instance.ChangeFeet(name);
        PopUp.instance.Shaded();

    }
}
