using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	// singleton pattern - only one instance of GameManager
	// "static" means you can access this instance from any other script with "GameManager.Instance"
	public static GameManager Instance;

	public int ObjectCount;
	public int TotalObjectCount;
	public TMPro.TextMeshProUGUI ObjectCountText;
	public TMPro.TextMeshProUGUI ObjectNameText;
	public Animator PopUpAnimator;


	private void Awake()
	{
		// set the instance to this object
		Instance = this;

		UpdateObjectCountText();
	}

	/// <summary>
	/// Called by InteractableObject when a it is interacted with
	/// </summary>
	/// <param name="interactableObject"></param>
	public void OnInteractWithObject(InteractableObject interactableObject)
	{
		// show the object name in the UI
		ObjectNameText.text = interactableObject.ObjectName;

		// increment the object count
		ObjectCount++;

		// update the text
		UpdateObjectCountText();

		// show the pop up
		PopUpAnimator.SetTrigger("Show");
	}

	private void UpdateObjectCountText()
	{
		// update the text
		ObjectCountText.text = ObjectCount + "/" + TotalObjectCount;
	}

}
