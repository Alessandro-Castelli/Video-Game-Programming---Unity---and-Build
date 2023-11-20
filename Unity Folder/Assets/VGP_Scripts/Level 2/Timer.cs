using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText; // Riferimento all'oggetto Text nell'interfaccia utente
    public float startingTime = 300f; // Tempo iniziale in secondi
    public GameObject vignettaTempoScaduto;
    private float currentTime; // Tempo corrente
    private bool tempoScaduto = false;

    private void Start()
    {
        currentTime = startingTime;
        vignettaTempoScaduto.SetActive(false);
    }

    private void Update()
    {

        if (!tempoScaduto)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                currentTime = 0f;
                Debug.Log("Tempo scaduto!");
                tempoScaduto = true; 
                vignettaTempoScaduto.SetActive(true);
                Invoke("changeScene", 3);

            }

            // Aggiorna il testo del timer nella UI
            int minutes = Mathf.FloorToInt(currentTime / 60f);
            int seconds = Mathf.FloorToInt(currentTime % 60f);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    private void changeScene() 
    {
        SceneManager.LoadScene("OpenWorld");
    } 
}
