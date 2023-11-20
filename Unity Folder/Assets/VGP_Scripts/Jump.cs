using UnityEngine;

public class Jump : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.Stop();
    }

    void Update()
    {
        // Verifica se la barra spaziatrice è stata premuta.
        if (Input.GetKeyDown(KeyCode.Space))
        {
                // Riproduci il suono.
                audioSource.Play();
        }
    }
 }

