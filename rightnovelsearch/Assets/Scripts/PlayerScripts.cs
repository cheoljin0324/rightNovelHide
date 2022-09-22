using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScripts : MonoBehaviour
{
    public GameObject scrollView;
    List<GameObject> getItem = new List<GameObject>();

    public void GetItem(GameObject item)
    {
        getItem.Add(item);
        SetItem();
    }

    public void SetItem()
    {
        getItem[getItem.Count].transform.parent = scrollView.transform;
    }
}
