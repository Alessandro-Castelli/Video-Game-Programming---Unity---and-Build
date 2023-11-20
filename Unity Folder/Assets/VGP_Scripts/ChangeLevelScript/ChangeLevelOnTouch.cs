using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

//QUando il player togga un oggetto passa al livello successivo
public class ChangeLevelOnTouch : MonoBehaviour
{
    public GameObject dring;
    public string livello;
    public int numeroMinPunti=0;
    public Text scoreText;
    public GameObject noPoints;

    private void Start()
    {
        noPoints.SetActive(false);
        dring.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        int punteggio = int.Parse(scoreText.text);

        if (other.CompareTag("Player") && punteggio >= numeroMinPunti)
        {
            dring.SetActive(true);
            Invoke("cambioScena", 3);

        }
        else 
        {
            noPoints.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        noPoints.SetActive(false);
    }

    void cambioScena() 
    {
        SceneManager.LoadScene(livello);
    }
}
