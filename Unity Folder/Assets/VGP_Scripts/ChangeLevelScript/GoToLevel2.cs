using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Questo script ti permette di andare al livello 2 quando premi il tasto "L"
public class GoToLevel2 : MonoBehaviour
{
    public string nomeLivelloSuccessivo;

    private void Update()
    {
        // Verifica se il tasto "L" è stato premuto
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Passa al livello successivo
            SceneManager.LoadScene(nomeLivelloSuccessivo);
        }
    }
}
