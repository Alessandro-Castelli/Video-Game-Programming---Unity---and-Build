using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadioCucinaFrancis : MonoBehaviour
{
    private Transform objectPosition;
    public Transform playerTransform;
    public float thresholdDistance = 3f;
    public static bool kitchenKey;
    public GameObject vignetta_locked;
    public GameObject vignetta_unlocked;
    public GameObject lucchetto;
    public AudioSource audioSource;
    private Animator animator;
    public GameObject Key;
    private bool status = false;
    public GameObject vignetta_opzione;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        objectPosition = GetComponent<Transform>();
        vignetta_unlocked.SetActive(false);
        vignetta_locked.SetActive(false);
        

    }


    // Update is called once per frame
    void Update()
    {

        // Controlla la distanza tra il giocatore e l'oggetto
        float distance = Vector3.Distance(objectPosition.transform.position, playerTransform.transform.position);
        //Debug.Log("Distanza misurata dall'armadio" + distance);
        // Se la distanza supera una certa soglia, disattiva la vignetta
        if (distance < thresholdDistance)
        {
            if (keyOfficeFrancis.keyOfficeFrancisTaken)
            {
                vignetta_unlocked.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    animator.SetTrigger("isOpen");
                    audioSource.enabled = true;
                    vignetta_unlocked.SetActive(false);
                    lucchetto.SetActive(false);
                    status = true;

                }
                if (status && !kitchenKey )
                {
                    vignetta_opzione.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.C))
                    {
                        kitchenKey = true;
                        Key.SetActive(false);

                    }
                }
                else
                {
                    vignetta_opzione.SetActive(false);
                }
                


            }
            else
            {
                vignetta_locked.SetActive(true);
            }


        }
        else
        {
            vignetta_unlocked.SetActive(false);
            vignetta_locked.SetActive(false);
            vignetta_opzione.SetActive(false);

        }

    }
}
