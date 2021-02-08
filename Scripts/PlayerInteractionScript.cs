using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    Interactable ObjectToInteract;
    public void InteractWithInteractable()
    {
        if (ObjectToInteract && ObjectToInteract.CanInteract())
        {
            ObjectToInteract.Interact();
        }
    }

    public void SubscribeInteractable(Interactable Object)
    {
        ObjectToInteract = Object;
    }

    public void UnsubscribeInteractable()
    {
        ObjectToInteract = null;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithInteractable();
        }
    }
}
