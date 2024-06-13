using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    public bool CanInteract = true;
    public string ObjectName;

    /// <summary>
    /// Called by PlayerInteract when the player interacts with the object
    /// </summary>
    public void Interact()
    {
        CanInteract = false;

        Debug.Log("Interact called");

        // TODO: Do more things here
        GameManager.Instance.OnInteractWithObject(this);

		gameObject.SetActive(false);
    }

}
