using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsCanvas : MonoBehaviour
{
    public GameObject mainmenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<AudioSource>().Play();
            mainmenu.SetActive(true);
            gameObject.SetActive(false);
        }
    }
 }
