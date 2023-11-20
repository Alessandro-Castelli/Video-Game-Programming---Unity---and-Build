using UnityEngine;

public class ApriSportello : MonoBehaviour
{
    public Animator animator;
    public GameObject E;
    public AudioSource click;
    private bool sportelloAperto = false;
    private bool triggerAvviato = false;

    private void Start()
    {
        E.SetActive(false);
        click.enabled = false;
    }
    private void Update()
    {
        if (triggerAvviato)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                click.enabled = true;
                Invoke("disattiva", 2);
                if (!sportelloAperto)
                {
                    animator.SetTrigger("open");
                    sportelloAperto = !sportelloAperto;
                }
                else
                {
                    animator.SetTrigger("close");
                    sportelloAperto = !sportelloAperto;
                }
            }

        }
    }

    private void disattiva()
    {
        click.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        E.SetActive(true);
        triggerAvviato = true; 
    }

    private void OnTriggerExit(Collider other)
    {
        E.SetActive(false);
        triggerAvviato = false;
    }

}
