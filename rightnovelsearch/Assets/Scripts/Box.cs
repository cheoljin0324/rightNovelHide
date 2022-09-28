using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : HideFloor
{
    //해당 Box안에 세팅 되어있는 아이템
    public GameObject settingItem;
    //박스의 오브젝트
    GameObject inGameItem;
    //아이템의 지정된 위치
    public Transform ItemTransform;
    //박스의 state 상태
    FloorState boxState = FloorState.Idle;
    //Player의 스크립트 컴포넌트
    PlayerScripts playerScripts;
    //해당 박스의 이미지
    Image myimage;

    //박스의 스프라이트(열림, 닫힘, 망가짐)
    public Sprite[] objectSprite;

    //캐싱
    private void Awake()
    {
        playerScripts = FindObjectOfType<PlayerScripts>();
        myimage = GetComponent<Image>();
    }

    private void Start()
    {
        //상태를 장애물로 변경
        boxState = FloorState.obstacle;
        //아이템을 생성
        inGameItem = GameObject.Instantiate(settingItem);
        //위치를 지정한 위치로 변경
        settingItem.transform.position = ItemTransform.transform.position;


    }

    public override void Obstacle()
    {
        //박스 열었음
        Open();
        //inGameItem의 오브젝트 enable을 false로 변경
        inGameItem.SetActive(false);
        //만약 settingItem이 null 이 아닐 경우 플레이어 스크립트의 겟 아이템을 세팅된 아이템을 매개변수로 실행(준다 아이템을)
        if (settingItem != null) { playerScripts.GetItem(settingItem); }
        //스프라이트를 열림 스프라이트로 변경
        myimage.sprite = objectSprite[0];
    }

    //열림
    public override void Open()
    {
        //박스 스테이트를 close로 변경
        boxState = FloorState.open;
        //스프라이트 열림으로 변경
        myimage.sprite = objectSprite[1];
    }

    //닫힘
    public override void close()
    {
        boxState = FloorState.close;
        myimage.sprite = objectSprite[0];
    }

}
