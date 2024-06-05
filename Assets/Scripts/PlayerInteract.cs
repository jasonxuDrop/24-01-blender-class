using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Interactable")
		{
			InteractableObject interactableObject = other.gameObject.GetComponent<InteractableObject>();
			if (interactableObject.CanInteract)
			{ 
				interactableObject.Interact();
			}
		}
	}

}
