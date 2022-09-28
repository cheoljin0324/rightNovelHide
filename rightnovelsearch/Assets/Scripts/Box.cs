using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : HideFloor
{
    //�ش� Box�ȿ� ���� �Ǿ��ִ� ������
    public GameObject settingItem;
    //�ڽ��� ������Ʈ
    GameObject inGameItem;
    //�������� ������ ��ġ
    public Transform ItemTransform;
    //�ڽ��� state ����
    FloorState boxState = FloorState.Idle;
    //Player�� ��ũ��Ʈ ������Ʈ
    PlayerScripts playerScripts;
    //�ش� �ڽ��� �̹���
    Image myimage;

    //�ڽ��� ��������Ʈ(����, ����, ������)
    public Sprite[] objectSprite;

    //ĳ��
    private void Awake()
    {
        playerScripts = FindObjectOfType<PlayerScripts>();
        myimage = GetComponent<Image>();
    }

    private void Start()
    {
        //���¸� ��ֹ��� ����
        boxState = FloorState.obstacle;
        //�������� ����
        inGameItem = GameObject.Instantiate(settingItem);
        //��ġ�� ������ ��ġ�� ����
        settingItem.transform.position = ItemTransform.transform.position;


    }

    public override void Obstacle()
    {
        //�ڽ� ������
        Open();
        //inGameItem�� ������Ʈ enable�� false�� ����
        inGameItem.SetActive(false);
        //���� settingItem�� null �� �ƴ� ��� �÷��̾� ��ũ��Ʈ�� �� �������� ���õ� �������� �Ű������� ����(�ش� ��������)
        if (settingItem != null) { playerScripts.GetItem(settingItem); }
        //��������Ʈ�� ���� ��������Ʈ�� ����
        myimage.sprite = objectSprite[0];
    }

    //����
    public override void Open()
    {
        //�ڽ� ������Ʈ�� close�� ����
        boxState = FloorState.open;
        //��������Ʈ �������� ����
        myimage.sprite = objectSprite[1];
    }

    //����
    public override void close()
    {
        boxState = FloorState.close;
        myimage.sprite = objectSprite[0];
    }

}
