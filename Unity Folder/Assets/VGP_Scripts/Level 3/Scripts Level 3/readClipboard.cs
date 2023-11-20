using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readClipboard : MonoBehaviour
{
    public GameObject vignetta;
    private bool triggerOn = false;

    private void Start()
    {
        vignetta.SetActive(false);
    }

    private void Update()
    {
        if (triggerOn && armadioCucinaFrancis.kitchenKey)
        {

            
            if (Input.GetKeyDown(KeyCode.R))
            {
                vignetta.SetActive(true); 
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        triggerOn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerOn = false;
        vignetta.SetActive(false);
    }
 
}
