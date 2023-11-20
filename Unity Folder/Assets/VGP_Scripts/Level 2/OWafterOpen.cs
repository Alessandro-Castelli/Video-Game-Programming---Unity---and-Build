using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OWafterOpen : MonoBehaviour
{
    private Quaternion rotazioneIniziale; // Rotazione iniziale dell'oggetto
    public Punteggio punteggio;
    public int scoreAdd;

    private void Start()
    {
        rotazioneIniziale = transform.rotation;
    }
    private void Update()
    {
        // Controlla se la posizione attuale dell'oggetto è diversa dalla posizione iniziale
        if (transform.rotation != rotazioneIniziale)
        {
            punteggio.IncreaseScore(scoreAdd);
            SceneManager.LoadScene("OpenWorld");            
        }
        
    }

}
