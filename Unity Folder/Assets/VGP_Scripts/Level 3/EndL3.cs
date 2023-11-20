using UnityEngine;
using UnityEngine.SceneManagement;

public class EndL3 : MonoBehaviour
{

    public string livello;
    public Punteggio punteggio;
    public static bool giaGiocatoL3 = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && armadioCucinaFrancis.kitchenKey)
        {
            if (!giaGiocatoL3)
            {
                punteggio.IncreaseScore(300);
                giaGiocatoL3 = true;
            }
           
            armadioCucinaFrancis.kitchenKey = false;
            DianePosterKey.DianeKey = false;
            keyOfficeFrancis.keyOfficeFrancisTaken = false;

            Invoke("cambioScena", 1);
        }
    }

    void cambioScena()
    {
        SceneManager.LoadScene(livello);
    }


}
