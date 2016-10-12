using UnityEngine;
using UnityEngine.UI;
using System.Collections;
/// <summary>
/// Variables for the planet script
/// Controls rotation
/// On gaze + trigger, show UI
/// When gaze Edits, hide UI
/// </summary>
/// 
public class PlanetScript : MonoBehaviour {

    // Public variables
    public float planetRotationSpeed; // For animating the planet movement

    // Private variables
    bool isFloating = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(isFloating)
        {
            gameObject.transform.Rotate(new Vector3(0.0f, planetRotationSpeed, 0.0f));
        }
    }
    /// <summary>
    /// Show or hide the UI based on whether or not it is showing already
    /// Will be called with EventTrigger OnPointerClick
    /// </summary>
    public void ShowHideUIDetails()
    {
        isFloating = false;
        transform.FindChild("PlanetCanvas").gameObject.SetActive(true);
        GetComponentInChildren<Canvas>().enabled = true;
        GetComponentInChildren<Canvas>().GetComponent<CanvasScaler>().dynamicPixelsPerUnit = 10;
    }

    /// <summary>
    /// Hide the UI for a planet when the user stops looking at it
    /// Will be called with EventTrigger OnPointerExit
    /// </summary>
    public void HideUIWhenGazeExit()
    {
        GetComponentInChildren<Canvas>().enabled = false;
        isFloating = true;
    }
}
