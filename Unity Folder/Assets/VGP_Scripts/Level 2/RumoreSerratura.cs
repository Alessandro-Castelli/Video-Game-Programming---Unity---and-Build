using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class RumoreSerratura : MonoBehaviour
{
    public GameObject[] luci;
    public AudioSource unlock;
    bool giaAscoltato=true;

    // Start is called before the first frame update
    void Start()
    {
        unlock.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool tuttiDisattivati = true;

        foreach (GameObject luci in luci) 
        {
            if (luci.activeSelf)
            {
                // Se almeno uno degli oggetti è attivo, impostare la variabile a false
                tuttiDisattivati = false;
                break;
            }
        }
        if (tuttiDisattivati && giaAscoltato)
        {
            unlock.enabled = true;
            giaAscoltato = false;
            Invoke("disabilita", 4);
        }

    }

    private void disabilita()

    {
        unlock.enabled = false;
    }
}
