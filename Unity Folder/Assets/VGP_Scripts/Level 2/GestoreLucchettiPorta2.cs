using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class GestoreLucchettiPorta2 : MonoBehaviour
{
    public LocKey lucchetto1;
    public LocKey lucchetto2;
    public GameObject[] daDisattivare1;
    public GameObject[] daDisattivare2;

    
    // Update is called once per frame
    void Update()
    {
        Verifica1(lucchetto1, daDisattivare1);
        Verifica1(lucchetto2, daDisattivare2);
    }

    private void Verifica1(LocKey lockey, GameObject[] luci) 
    {
        bool tuttiDisattivati = true;
        

        // Controlla lo stato di attivazione di tutti gli oggetti da controllare
        foreach (GameObject oggetto in luci)
        {
            if (oggetto.activeSelf)
            {
                // Se almeno uno degli oggetti è attivo, impostare la variabile a false
                tuttiDisattivati = false;
                break;
            }
        }

        // Esegui l'azione desiderata se tutti gli oggetti sono disattivati
        if (tuttiDisattivati)
        {
            
            if (lockey != null)
            {
                lockey.openLock();               
                
            }
            
        }
    }

}

