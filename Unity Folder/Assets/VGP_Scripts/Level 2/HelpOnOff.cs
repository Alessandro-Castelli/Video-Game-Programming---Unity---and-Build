using UnityEngine;

public class HelpOnOff : MonoBehaviour
{
    public GameObject bubble; // L'oggetto di riferimento da controllare
    public GameObject R;
    private Quaternion rotazioneIniziale; // Rotazione iniziale dell'oggetto

    private void Start()
    {
        rotazioneIniziale = transform.rotation;
        R.SetActive(false);
        bubble.SetActive(false);
    }
    private void Update()
    {
        // Controlla se la posizione attuale dell'oggetto è diversa dalla posizione iniziale
        if (transform.rotation != rotazioneIniziale)
        {
            R.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R)) 
            {
                bubble.SetActive(!bubble.activeSelf);
            }
            
        } else 
        { 
            bubble.SetActive(false);
            R.SetActive(false);
        }
    }
}
