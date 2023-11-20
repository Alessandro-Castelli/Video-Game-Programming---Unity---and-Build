using UnityEngine;

public class FootStep : MonoBehaviour
{
    public AudioSource walkAudioSource;
    public AudioSource runAudioSource;

    void Start()
    {

        walkAudioSource.enabled = false;
        runAudioSource.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            // Il personaggio sta muovendosi.
            if (Input.GetKey(KeyCode.LeftShift))
            {
                // Il personaggio sta correndo.
                walkAudioSource.enabled = false; // Disattiva l'Audio Source di camminata.
                runAudioSource.enabled = true;   // Attiva l'Audio Source di corsa.
            }
            else
            {
                // Il personaggio sta camminando.
                walkAudioSource.enabled = true;  // Attiva l'Audio Source di camminata.
                runAudioSource.enabled = false;  // Disattiva l'Audio Source di corsa.
            }
        }
        else
        {
            // Il personaggio non sta muovendosi.
            walkAudioSource.enabled = false; // Disattiva l'Audio Source di camminata.
            runAudioSource.enabled = false;  // Disattiva l'Audio Source di corsa.
        }
    }
}


