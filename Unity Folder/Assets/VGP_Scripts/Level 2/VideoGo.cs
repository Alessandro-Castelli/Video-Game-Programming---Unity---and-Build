using UnityEngine;

public class VideoGo : MonoBehaviour
{
    public GameObject planeVideo;
    public Transform player;
    public float approachDistance = 5f;
    private bool disattivoVideo = false;
    private bool disattivato = true;
    public LocKey serratura;
    public AudioSource unlock;
    public Transform portaTelevisione;
    private Quaternion rotazioneIniziale;
    private Quaternion rotazioneaggiornata;

    // Start is called before the first frame update
    void Start()
    {
        rotazioneIniziale =  portaTelevisione.rotation;
        planeVideo.SetActive(false);
        unlock.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotazioneaggiornata = portaTelevisione.rotation;
        float distance = Vector3.Distance(player.transform.position, transform.position);
        //Debug.Log(distance);

        if (rotazioneIniziale != rotazioneaggiornata && disattivato)
        {
            planeVideo.SetActive(true);
        }
        else
        {
            planeVideo.SetActive(false);
        }


        if (distance < approachDistance && Input.GetKeyDown(KeyCode.E))
        {
            disattivoVideo = !disattivoVideo; // Inverte lo stato di disattivoVideo

            // Controlla lo stato di disattivoVideo e imposta di conseguenza l'attivazione di planeVideo
            if (disattivoVideo)
            {
                planeVideo.SetActive(false);
                disattivato = false;
                serratura.openLock();
                unlock.enabled = true;
            }
            else
            {
                planeVideo.SetActive(true);
                disattivato = true;
                serratura.closeLock();
                
            }
        }  
    }

    private void OnTriggerExit(Collider other)
    {
        unlock.enabled = false; 
    }

}
