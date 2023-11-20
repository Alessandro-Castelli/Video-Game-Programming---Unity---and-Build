using UnityEngine;

public class SpegniAccendiLuci : MonoBehaviour
{
    public GameObject luce;
    public AudioSource click;
    public GameObject E;
    private bool stato;
    private bool isInRange;    

    private void Start()
    {
        isInRange = false;
        click.enabled = false;
        E.SetActive(false);
    }
    private void Update()
    {
        stato = luce.activeSelf;
        if (Input.GetKeyDown(KeyCode.E) && isInRange )
        { 
            luce.SetActive(!stato);
            click.enabled = true;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isInRange = true;
        E.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
        click.enabled=false;
        E.SetActive(false);
    }
}
