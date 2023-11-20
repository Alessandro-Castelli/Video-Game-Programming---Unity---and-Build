using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class keyOfficeFrancis : MonoBehaviour
{
    public GameObject vignetta;
    private Transform objectPosition;
    public Transform playerTransform;
    public float thresholdDistance = 2f;
    public static bool keyOfficeFrancisTaken = false;
    public GameObject officeKey;
    public GameObject vignetta_opzione;

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
        if (distance < thresholdDistance)
        {
            if (!keyOfficeFrancisTaken)
            {
                vignetta.SetActive(true);
                vignetta_opzione.SetActive(true);
                
            }
             
            if (Input.GetKeyUp(KeyCode.E))
            {
                keyOfficeFrancisTaken = true;
                officeKey.SetActive(false);
                vignetta_opzione.SetActive(false);
            }
        }
        else
        {
            vignetta.SetActive(false);
            vignetta_opzione.SetActive(false);
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


