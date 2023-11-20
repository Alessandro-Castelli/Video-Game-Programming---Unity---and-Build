using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Quando il Player si avvicina ad un oggetto(Lo uso per i box) spunta una vignetta informativa
public class VignettaProssimita : MonoBehaviour
{

    public GameObject vignetta;
    private Transform objectPosition;
    public Transform playerTransform;
    public float thresholdDistance=2f;
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
            Debug.Log("Distanza misurata" + distance);
            // Se la distanza supera una certa soglia, disattiva la vignetta
            if (distance > thresholdDistance)
            {
                vignetta.SetActive(false);
            }
            else
            {
                vignetta.SetActive(true);
            }
        
    }
    

    
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
}
