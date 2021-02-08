using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : Interactable
{
    public override void Interact()
    {
        Debug.Log("Player has interacted with a chest!");
    }
}
