using UnityEngine;


//QUesto metodo serve per attivare e disattivare il menu
public class ActiveMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject disableplayer;
    private void Start()
    {
         menu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Attiva o disattiva il menu.
            menu.SetActive(!menu.activeSelf);
            disableplayer.SetActive(!disableplayer.activeSelf);

            // Verifica se il menu è attivo e metti in pausa il tempo di gioco se lo è.
            if (menu.activeSelf)
            {
                Time.timeScale = 0f; // Metti in pausa il tempo di gioco.
            }
            else
            {
                Time.timeScale = 1f; // Ripristina il tempo di gioco normale.
            }
        }
        
    }
}
