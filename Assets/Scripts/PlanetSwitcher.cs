using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Experimental.GlobalIllumination;
public class PlanetSwitcher : MonoBehaviour
{
    public List<GameObject> planetModels; 
    public TextMeshProUGUI planetNameText; 
    public GameObject lightmodel;
    public GameObject Sun;
    public GameObject SolarSystem;

    private int currentIndex = 0;

    void Start()
    {
      
        lightmodel.SetActive(false);
        UpdateView();
    }

    public void NextPlanet()
    {
     
        currentIndex = (currentIndex + 1) % planetModels.Count; 
        UpdateView();
    }

    public void PreviousPlanet()
    {
      
        currentIndex = (currentIndex - 1 + planetModels.Count) % planetModels.Count; 
        UpdateView();
    }

    public void CancelView()
    {
        currentIndex = 0; 
        UpdateView();
    }

    private void UpdateView()
    {
       
        foreach (GameObject model in planetModels)
        {
        
            model.SetActive(false);
        }

        if (planetModels[currentIndex] == Sun | planetModels[currentIndex] == SolarSystem)
        {
            lightmodel.SetActive(false);
        }
        else
        {
            lightmodel.SetActive(true);
        }

        planetModels[currentIndex].SetActive(true);
        planetNameText.text = planetModels[currentIndex].name;
    }
}
