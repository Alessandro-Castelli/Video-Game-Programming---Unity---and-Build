
using UnityEngine;
using UnityEngine.SceneManagement;

//QUando il player togga un oggetto passa al livello successivo
public class backToOpenWorld : MonoBehaviour
{
    public string livello;
    public Punteggio punteggio;    
    public static bool giaGiocatoL1 = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && openDoors.bedroomKey)
        {
            if (!giaGiocatoL1)
            {
                punteggio.IncreaseScore(100);
                giaGiocatoL1=true;
            }
            keyBathroom.bathKeyTaken = false;
            openDoors.bedroomKey = false;
            DisableSinkAnimation.waterClosed = false;
            Invoke("cambioScena", 1);
        }
    }

    void cambioScena()
    {
        SceneManager.LoadScene(livello);
    }

   
}
