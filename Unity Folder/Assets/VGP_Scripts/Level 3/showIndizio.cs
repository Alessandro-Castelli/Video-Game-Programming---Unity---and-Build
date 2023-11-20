using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showIndizio : MonoBehaviour
{
    public GameObject vignetta; // Riferimento all'oggetto della vignetta
    private bool already_seen = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") & !keyBathroom.bathKeyTaken) // Assicurati che il player abbia il tag corretto
        {
            //Debug.Log("Collisione con l'oggetto desiderato.");
            vignetta.SetActive(true); // Attiva l'oggetto della vignetta
            //Invoke("DisableVignetta", 2f); // Disattiva l'oggetto della vignetta dopo 5 secondi
            already_seen = true;
        }
    }

   

    private void OnTriggerExit(Collider other)
    {
        vignetta.SetActive(false);

    }
}
