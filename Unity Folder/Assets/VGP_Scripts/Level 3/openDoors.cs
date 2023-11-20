using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoors : MonoBehaviour
{
    private Transform objectPosition;
    public Transform playerTransform;
    public float thresholdDistance = 3f;
    public static bool bedroomKey;
    public GameObject vignetta_locked;
    public GameObject vignetta_unlocked;
    public GameObject vignetta_vittoria;
    public GameObject vignetta_chiave_raccolta;
    public GameObject lucchetto;
    public AudioSource audioSource;
    private Animator animator;
    public GameObject bedKey;
    private bool status = false;

    private bool not_seen = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        objectPosition = GetComponent<Transform>();
        vignetta_unlocked.SetActive(false);
        vignetta_locked.SetActive(false);
        vignetta_vittoria.SetActive(false);
        vignetta_chiave_raccolta.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {

        // Controlla la distanza tra il giocatore e l'oggetto
        float distance = Vector3.Distance(objectPosition.transform.position, playerTransform.transform.position);
        //Debug.Log("Distanza misurata dall'armadio" + distance);
        // Se la distanza supera una certa soglia, disattiva la vignetta
        if (distance < thresholdDistance )
        {
            if (keyBathroom.bathKeyTaken)
            {
                vignetta_unlocked.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    
                    //animator.SetBool("isOpen", true);
                    animator.SetTrigger("isOpen");
                    audioSource.enabled = true;
                    vignetta_unlocked.SetActive(false);
                    
                    lucchetto.SetActive(false);
                    status = true;

                }
            }
            else
            {
                vignetta_locked.SetActive(true);
            }

            if (status && !not_seen)
            {
                vignetta_chiave_raccolta.SetActive(true);
                if (Input.GetKeyDown(KeyCode.C))
                {
                    bedroomKey = true;
                    bedKey.SetActive(false);
                    vignetta_chiave_raccolta.SetActive(false);
                    vignetta_vittoria.SetActive(true);
                    not_seen = true;

                }
            }
            
        }
        else
        {
            vignetta_unlocked.SetActive(false);
            vignetta_locked.SetActive(false);
            vignetta_chiave_raccolta.SetActive(false);

        }

    }
}
