using UnityEngine;

public class ActiveMenu3 : MonoBehaviour
{
    public GameObject menu;
    public GameObject disableplayer;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(!menu.activeSelf);
            disableplayer.SetActive(!disableplayer.activeSelf);


            if (menu.activeSelf)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }

        }
    }
}
