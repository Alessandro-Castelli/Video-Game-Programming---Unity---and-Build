using UnityEngine;

//Quando il Player si avvicina ad un oggetto(Lo uso per i box) spunta una vignetta informativa
public class DisableSinkAnimation : MonoBehaviour
{

    public GameObject vignetta_opzione;
    public GameObject vignetta_messaggio;
    private Transform objectPosition;
    public Transform playerTransform;
    public float thresholdDistance = 2f;
    public static bool waterClosed = false;
    public GameObject sink;
    private bool already_seen = false;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        objectPosition = GetComponent<Transform>();
        vignetta_opzione.SetActive(false);
        vignetta_messaggio.SetActive(false);
        audioSource.enabled = true;
    }


    // Update is called once per frame
    void Update()
    {

        // Controlla la distanza tra il giocatore e l'oggetto
        float distance = Vector3.Distance(objectPosition.transform.position, playerTransform.transform.position);
        
        // Se la distanza supera una certa soglia, disattiva la vignetta
        if (distance > thresholdDistance)
        {
            vignetta_opzione.SetActive(false);
        }
        else
        {
            if (!waterClosed)
            {
                vignetta_opzione.SetActive(true);
            }
            
            if (Input.GetKeyUp(KeyCode.C) && !waterClosed && !keyBathroom.bathKeyTaken)
            {
                waterClosed = true;
                sink.SetActive(false);
                audioSource.enabled = false;

                vignetta_opzione.SetActive(false);
                

            }
        }

        if (waterClosed && !keyBathroom.bathKeyTaken)
        {
            
                vignetta_messaggio.SetActive(true);
        }
        else
        {
                vignetta_messaggio.SetActive(false);
        }

    }


    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vignetta_opzione.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vignetta_opzione.SetActive(false);
        }

    }
    */
}
