using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Experimental.GlobalIllumination;


public class description : MonoBehaviour
{
    [SerializeField] public  string  physical;
    [SerializeField] public string orbital;

    public TextMeshProUGUI descriptionField;


    void Start()
    {
       setPhysical();
    }

    public void setorbital()
    {
        descriptionField.text = orbital;
    }

    public void setPhysical()
    {
        descriptionField.text = physical;
    }
}
