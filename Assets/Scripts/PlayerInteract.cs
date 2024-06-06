using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Interactable")
		{
			InteractableObject interactableObject = other.GetComponent<InteractableObject>();
			if (interactableObject != null && interactableObject.CanInteract)
			{
				interactableObject.Interact();
			}
		}
	}

}
