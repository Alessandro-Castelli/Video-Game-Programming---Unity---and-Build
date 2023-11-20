using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DianePosterKey : MonoBehaviour
{

    
    public static bool DianeKey = false;
    public GameObject vignetta;
    private bool entered = false;

    private void Update()
    {
        if (entered && Input.GetKey(KeyCode.E))
        {
            
           DianeKey = true;
           gameObject.SetActive(false);
        }
        
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        vignetta.SetActive(true);
        entered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        vignetta.SetActive(false);
        entered = false;
    }
}
