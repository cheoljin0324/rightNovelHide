using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HideFloor : MonoBehaviour
{
    public abstract void Obstacle();
    public abstract void Open();
    public abstract void close();
    public virtual void ItemGet() { }
}

public enum FloorState
{
    Idle,
    obstacle,
    open,
    close
}