using UnityEngine;

public class VideoGameGo : MonoBehaviour
{
    public Transform player;
    public GameObject planeVideo;
    public GameObject E;
    public GameObject daPassarePorta;
    public float approachDistance = 6;
    private bool disattivoVideo = false;
    private bool disattivato = true;

    // Start is called before the first frame update
    void Start()
    {
        E.SetActive(false);
        planeVideo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < approachDistance && Input.GetKeyDown(KeyCode.E))
        {
            disattivoVideo = !disattivoVideo; // Inverte lo stato di disattivoVideo

            // Controlla lo stato di disattivoVideo e imposta di conseguenza l'attivazione di planeVideo
            if (disattivoVideo)
            {
                planeVideo.SetActive(false);
                disattivato = false;
                daPassarePorta.SetActive(false);
            }
            else
            {
                planeVideo.SetActive(true);
                disattivato = true;
                daPassarePorta.SetActive(true); 
            }
        }

        

    }

    private void OnTriggerEnter(Collider other) 
    {

        E.SetActive(true);
        if (disattivato)
        {
            planeVideo.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        E.SetActive(false);
    }
}

