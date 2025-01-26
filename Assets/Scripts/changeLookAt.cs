using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    public GameObject solarSystemModel; // The whole solar system model
    public GameObject target; // The target the planets will look at
    public float scaleFactor = 1.0f; // Factor to scale the solar system

    void Start()
    {
        // Optionally, you can initialize things here if needed
    }

    private void ScaleSolarSystem(float scale)
    {
        // Scale the whole solar system model
        if (solarSystemModel != null)
        {
            solarSystemModel.transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            Debug.LogWarning("Solar system model is not assigned.");
        }
    }
    private void OnMouseDown()
    {
        // Check if the clicked object is the target
        if (target != null && target == gameObject)
        {
            // Set the target for looking at (if you have a LookAt script)
            LookAt.target = target;

            // Scale the entire solar system model
            ScaleSolarSystem(scaleFactor);
        }
    }

 
}
