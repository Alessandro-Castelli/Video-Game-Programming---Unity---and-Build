using UnityEngine;

// Questa classe serve per la gestionde delle porte senza serratura
public class Open : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    public GameObject button;
    public float approachDistance = 2;
    public AudioSource porta;
    private bool isOpen = false;

    // Start is called before the first frame update

    private void Start()
    {
        button.SetActive(false);
        porta.enabled = false;
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
                     animator.SetTrigger("open");
                     isOpen = true;
                     porta.enabled = true;
                    
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
    }
}


