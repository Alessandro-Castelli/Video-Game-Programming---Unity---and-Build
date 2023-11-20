using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGreenDoor : MonoBehaviour
{
    private bool door_open = false;
    private Animator animator;
    public GameObject vignetta_locked;
    public GameObject vignetta_unlocked;
    private bool entered = false;
    private void Start()
    {
        vignetta_unlocked.SetActive(false);
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (entered)
        {
            
            if (DianePosterKey.DianeKey)
            {
                vignetta_locked.SetActive(false);
                vignetta_unlocked.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    if (door_open)
                    {
                        animator.SetTrigger("greenDoorClose");
                    }
                    else
                    {
                        animator.SetTrigger("greenDoorOpen");
                    }

                }
            }
            else
            {
                vignetta_unlocked.SetActive(false);
                vignetta_locked.SetActive(true);
                
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        entered = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        vignetta_locked.SetActive(false);
        vignetta_unlocked.SetActive(false);
        entered = false;
    }
}
