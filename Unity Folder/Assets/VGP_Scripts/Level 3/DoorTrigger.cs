using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    
    private Animator animator;
    private Transform objectPosition;
    public Transform playerTransform;
    public float thresholdDistance = 3f;
    private bool open_status = false;
    public AudioSource audioSource_open;
    public AudioSource audioSource_close;
    public GameObject vignetta;

    private void Start()
    {
        animator = GetComponent<Animator>();
        objectPosition = GetComponent<Transform>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(objectPosition.transform.position, playerTransform.transform.position);

        if (distance < thresholdDistance)
        {
            vignetta.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                if (!open_status)
                {

                    animator.SetTrigger("Door_open");
                    audioSource_open.enabled = true;
                    open_status = true;
                }
                else
                {

                    animator.SetTrigger("Door_close");
                    audioSource_close.enabled = true;
                    open_status = false;
                }
            }


        }
        else
        {
            vignetta.SetActive(false);
        }
    }
}
