using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : HideFloor
{
    public GameObject settingItem;
    GameObject inGameItem;
    public Transform ItemTransform;
    FloorState boxState = FloorState.Idle;
    PlayerScripts playerScripts;
    Image myimage;

    public Sprite[] objectSprite;

    private void Awake()
    {
        playerScripts = FindObjectOfType<PlayerScripts>();
        myimage = GetComponent<Image>();
    }

    private void Start()
    {
        boxState = FloorState.obstacle;
        inGameItem = GameObject.Instantiate(settingItem);
        settingItem.transform.position = ItemTransform.transform.position;


    }

    public override void Obstacle()
    {
        Open();
        inGameItem.SetActive(false);
        if (settingItem != null) { playerScripts.GetItem(settingItem); }
        myimage.sprite = objectSprite[0];
    }

    public override void Open()
    {
        boxState = FloorState.close;
        myimage.sprite = objectSprite[0];
    }

    public override void close()
    {
        boxState = FloorState.open;
        myimage.sprite = objectSprite[1];
    }

}
