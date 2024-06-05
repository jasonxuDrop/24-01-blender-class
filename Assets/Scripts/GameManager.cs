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
	public Animator PopupAnimator;

	private void Awake()
	{
		// set the instance to this object
		Instance = this;
		SetObjectCountText(); // update text to show initial object count
	}

	/// <summary>
	/// Called when the player interacts with an object. (for updating the UI)
	/// </summary>
	/// <param name="interactableObject"></param>
	public void OnInteractWithObject(InteractableObject interactableObject)
	{
		// things happen
		ObjectCount++;
		SetObjectCountText(); // update text to show new object count
		ObjectNameText.text = interactableObject.ObjectName; // set the object name text
		PopupAnimator.SetTrigger("NewObject"); // play the new object panel animation
	}

	/// <summary>
	/// Updates the text that shows the number of objects collected.
	/// </summary>
	private void SetObjectCountText()
	{
		ObjectCountText.text = ObjectCount + "/" + TotalObjectCount;
	}
}
