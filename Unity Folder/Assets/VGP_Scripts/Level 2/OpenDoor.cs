using UnityEngine;

//Questa classe serve per la gestionde delle porte con una serratura
public class OpenDoor : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    public GameObject button;
    public float approachDistance = 2;
    public AudioSource porta;
    public AudioSource doorLock;
    private bool isOpen=false;
    public LocKey serratura;
    public GameObject mancaLaChiave;

    // Start is called before the first frame update

    private void Start()
    {
        button.SetActive(false);
        porta.enabled = false;
        doorLock.enabled = false;
        mancaLaChiave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= approachDistance)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isOpen)
                {
                    animator.SetTrigger("close");
                    isOpen = false;
                    porta.enabled = true;
                }
                else
                {
                    if (serratura.isopen())
                    {
                        animator.SetTrigger("open");
                        isOpen = true;
                        porta.enabled = true;
                    }
                    else 
                    {
                        mancaLaChiave.SetActive(true);
                        doorLock.enabled = true;

                    }
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        button.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        button.SetActive(false);
        porta.enabled = false;
        mancaLaChiave.SetActive(false);
        doorLock.enabled = false;
    }
}

    