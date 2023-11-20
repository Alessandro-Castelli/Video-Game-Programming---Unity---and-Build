using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{

    private Text scoreText; // Riferimento all'oggetto Text per il punteggio
    private int score = 0;

    private void Start()
    {
       
        scoreText = GetComponent<Text>();
        score = PlayerPrefs.GetInt("Score"); 
        UpdateScoreText(); // Aggiorna il testo del punteggio all'avvio del gioco
    }

    public void IncreaseScore(int amount)
    {
        score += amount; // Incrementa il punteggio
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
        UpdateScoreText(); // Aggiorna il testo del punteggio
    }

    private void UpdateScoreText()
    {
        scoreText.text = ""+score; // Aggiorna il testo del punteggio nell'oggetto Text
    }
}
      
