using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject vignetta;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vignetta.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            vignetta.SetActive(false);
        }
    }
}

