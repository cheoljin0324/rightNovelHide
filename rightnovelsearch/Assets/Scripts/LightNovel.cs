using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightNovel : ElementsItem
{

    public bool Selection = false;
    PlayerScripts playerSetting;

    private void Awake()
    {
        playerSetting = FindObjectOfType<PlayerScripts>();
    }

    public override void selectionPlayer()
    {
        
    }

    public override void elementUse()
    {

    }

}
