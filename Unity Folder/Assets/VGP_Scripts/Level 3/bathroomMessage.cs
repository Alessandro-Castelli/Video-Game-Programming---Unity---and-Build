using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class bathroomMessage : MonoBehaviour
{
    public GameObject vignetta; // Riferimento all'oggetto della vignetta
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !keyBathroom.bathKeyTaken) // Assicurati che il player abbia il tag corretto
        {
            //Debug.Log("Collisione con l'oggetto desiderato.");
            vignetta.SetActive(true); // Attiva l'oggetto della vignetta
            //Invoke("DisableVignetta", 2f); // Disattiva l'oggetto della vignetta dopo 5 secondi
        }
    }

    private void OnTriggerExit(Collider other)
    {
        vignetta.SetActive(false);
       
    }

}
