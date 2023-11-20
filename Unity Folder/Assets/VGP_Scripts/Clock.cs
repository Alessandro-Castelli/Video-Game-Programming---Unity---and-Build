using UnityEngine;
using TMPro;

public class DigitalClock : MonoBehaviour
{
    public TMP_Text clockText;                    // Riferimento al componente TextMeshProUGUI per visualizzare l'orario
    public float timeScale = 2f;                   // Scala di tempo per simulare 24 ore in x minuti

    private float currentTime;                     // Tempo corrente in minuti

    private void Start()
    {
        currentTime = 0f;
    }

    private void Update()
    {
        // Calcola il numero totale di minuti trascorsi
        currentTime += Time.deltaTime * timeScale;

        // Assicurati che il tempo rimanga all'interno del range delle 24 ore
        if (currentTime >= 1440f)
        {
            currentTime -= 1440f;
        }

        // Calcola le ore e i minuti corrispondenti
        int hours = (int)(currentTime / 60f);
        int minutes = (int)(currentTime % 60f);

        // Formatta l'orario in una stringa nel formato HH:MM
        string timeString = string.Format("{0:00}:{1:00}", hours, minutes);

        // Aggiorna il testo dell'orologio digitale
        clockText.text = timeString;
    }
}
