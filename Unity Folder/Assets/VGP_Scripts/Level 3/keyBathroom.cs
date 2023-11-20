using UnityEngine;
public class keyBathroom : MonoBehaviour
{
    public GameObject vignetta;
    private Transform objectPosition;
    public Transform playerTransform;
    public float thresholdDistance = 2f;
    public static bool bathKeyTaken = false;
    public GameObject bathKey;
    
    // Start is called before the first frame update
    void Start()
    {
        objectPosition = GetComponent<Transform>();
        vignetta.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

        // Controlla la distanza tra il giocatore e l'oggetto
        float distance = Vector3.Distance(objectPosition.transform.position, playerTransform.transform.position);
        //Debug.Log("Distanza misurata" + distance);
        // Se la distanza supera una certa soglia, disattiva la vignetta
        if (distance < thresholdDistance && DisableSinkAnimation.waterClosed)
        {
            if (!bathKeyTaken)
            {
                vignetta.SetActive(true);
            }
            
            if (Input.GetKeyUp(KeyCode.E))
            {
                bathKeyTaken = true;
                bathKey.SetActive(false);
            }
        }
        else
        {
            vignetta.SetActive(false);
        }

    }

    /*

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vignetta.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vignetta.SetActive(false);
        }
    }
    */
}

