using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FocusOnPlanet : MonoBehaviour
{
    public Camera arCamera; // Reference to your AR Camera
    public GameObject solarSystem; // Reference to the parent GameObject containing all planets
    public float focusDistance = 5f; // Distance from the planet to focus on
    public float moveDuration = 1.5f; // Duration for camera movement
    public float scaleDuration = 1f; // Duration for scaling

    // This function will be called when a button is clicked
    public void OnButtonClick(GameObject targetPlanet)
    {
        StartCoroutine(FocusCamera(targetPlanet));
        StartCoroutine(ScaleSolarSystem(targetPlanet));
    }

    private IEnumerator FocusCamera(GameObject targetPlanet)
    {
        Vector3 targetPosition = targetPlanet.transform.position + new Vector3(0, 0, -focusDistance);
        float elapsedTime = 0f;
        Vector3 startingPosition = arCamera.transform.position;

        while (elapsedTime < moveDuration)
        {
            arCamera.transform.position = Vector3.Lerp(startingPosition, targetPosition, (elapsedTime / moveDuration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        arCamera.transform.position = targetPosition; // Ensure final position is set
    }

    private IEnumerator ScaleSolarSystem(GameObject targetPlanet)
    {
        Vector3 originalScale = solarSystem.transform.localScale;
        Vector3 targetScale = originalScale * 2; // Adjust scale factor as needed for zoom effect
        float elapsedTime = 0f;

        while (elapsedTime < scaleDuration)
        {
            solarSystem.transform.localScale = Vector3.Lerp(originalScale, targetScale, (elapsedTime / scaleDuration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        solarSystem.transform.localScale = targetScale; // Ensure final scale is set
    }
}
