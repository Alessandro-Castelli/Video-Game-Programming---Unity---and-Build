using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VignettaTrigger : MonoBehaviour
{
    public GameObject vignetta; // Riferimento all'oggetto della vignetta

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assicurati che il player abbia il tag corretto
        {
            //Debug.Log("Collisione con l'oggetto desiderato.");
            vignetta.SetActive(true); // Attiva l'oggetto della vignetta
           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Assicurati che il player abbia il tag corretto
        {
            //Debug.Log("Collisione con l'oggetto desiderato.");
            vignetta.SetActive(false); // Attiva l'oggetto della vignetta

        }
    }
}
