using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInteractable : MonoBehaviour, IInteractable
{
    public void Interact(GameObject Instigator)
    {
        Debug.Log("THATS IT");
    }
}
