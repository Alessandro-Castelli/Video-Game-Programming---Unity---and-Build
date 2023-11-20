using UnityEngine;

public class GestorePassi : MonoBehaviour
{
    public GameObject walk;
    public GameObject run;
    // Start is called before the first frame update
    void Start()
    {
        walk.SetActive(false);
        run.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A))
        {
            walk.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        { 
            run.SetActive(true);
            walk.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            run.SetActive(false);
            walk.SetActive(true);
        }

        if (!Input.anyKey)
        {
            walk.SetActive(false);
            run.SetActive(false);
        }
    }

}
