using UnityEngine;

public class SpegniAccendiRadio : MonoBehaviour
{
    public GameObject radiomusica;
    public AudioSource click;
    public GameObject E;
    public GameObject daPassarePorta;
    private bool attiva;
    private bool dentroTrigger;
    private void Start()
    {
        E.SetActive(false);
        attiva = true;
        radiomusica.SetActive(false);
        click.enabled = false;
        E.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && dentroTrigger)
        {
            E.SetActive(true);
            radiomusica.SetActive(!radiomusica.activeSelf);
            attiva = !attiva;
            click.enabled = true;
            Invoke("DisableAudio", 1);
            daPassarePorta.SetActive(!daPassarePorta.activeSelf);
        }
    }

    private void DisableAudio() 
    { 
        click.enabled = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        E.SetActive(true);
        dentroTrigger = true;
        if (attiva)
        { 
            radiomusica.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        radiomusica.SetActive(false);
        dentroTrigger=false;
        E.SetActive(false);
    }
}
