using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    public bool CanInteract = true;

    public string ObjectName;

    public void Interact()
    {
        CanInteract = false;

		Debug.Log("Interacting with " + gameObject.name);

        GameManager.Instance.OnInteractWithObject(this);
        
        gameObject.SetActive(false);
	}

}
