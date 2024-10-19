using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareInteractable : MonoBehaviour, IInteractable
{
    public void Interact(GameObject Instigator)
    {
        Debug.Log("THERE IT IS THERE IT IS THERE IT IS");
    }
}
