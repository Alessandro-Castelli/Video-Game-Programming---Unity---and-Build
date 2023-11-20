using UnityEngine;


public class AddPointsPlastic : MonoBehaviour
{
    private Transform objectPosition;
    public Transform player;
    public float thresholdDistance = 5f;
    public GameObject vignettaTasto;
    public Punteggio scoreManager;
    public AudioSource clicksound;

    // Start is called before the first frame update
    void Start()
    {
        objectPosition = GetComponent<Transform>();
        clicksound.enabled = false;
        vignettaTasto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(objectPosition.transform.position, player.transform.position);
        //Debug.Log(distance);
        if (distance < thresholdDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                clicksound.enabled = true;
                clicksound.Play();
                vignettaTasto.SetActive(false);
                scoreManager.IncreaseScore(1);
                Destroy(gameObject);
            }
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        vignettaTasto.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {

        vignettaTasto.SetActive(false);
    }
}
