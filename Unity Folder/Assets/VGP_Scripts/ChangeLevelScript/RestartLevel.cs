using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assicurati che il player abbia il tag corretto
        {
            Debug.Log("Collisione con l'oggetto desiderato, riavvio il livello.");
            Restart();
        }
    }

    private void Restart()
    {
        // Ricarica la scena corrente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
