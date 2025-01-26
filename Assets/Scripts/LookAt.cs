using UnityEngine;
using Vuforia;

public class LookAt : MonoBehaviour
{

    static public GameObject target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform);
        }
    }
}
