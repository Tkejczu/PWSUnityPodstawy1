using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float maxDistanceToPlayer = 3f;
    public GameObject player;

    public virtual void Interact()
    {
        Debug.Log("Player has interacted with an object!");
    }

    public virtual bool CanInteract()
    {
        if (player)
        {
            return Vector3.Distance(this.transform.position, player.transform.position) <= maxDistanceToPlayer;
        }
        else
            return false;
    }

    void OnCollisionEnter(Collision collision)
    {
        PlayerInteractionScript playerInteraction = collision.gameObject.GetComponent<PlayerInteractionScript>();
        
        if (playerInteraction)
        {
            player = collision.gameObject;
            playerInteraction.SubscribeInteractable(this);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        PlayerInteractionScript playerInteraction = collision.gameObject.GetComponent<PlayerInteractionScript>();
        
        if (playerInteraction)
        {
            playerInteraction.UnsubscribeInteractable();
            player = null;
        }
    }
}
