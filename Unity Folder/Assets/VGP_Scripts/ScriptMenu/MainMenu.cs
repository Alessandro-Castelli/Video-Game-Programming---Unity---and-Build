using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject vignettaCaricamento;
    //public GameObject settingsCanvas;
    public GameObject mainmenucanvas;
    public AudioSource clicksound;

    private void Start()
    {
        vignettaCaricamento.SetActive(false);
        //settingsCanvas.SetActive(false);
        mainmenucanvas.SetActive(true);
    }

    void Update()
    {   //abbandona il gioco
        if (Input.GetKeyDown(KeyCode.Q) && mainmenucanvas.activeSelf)
        {
            vignettaCaricamento.SetActive(true);
            clicksound.Play();

            #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
            #else
	            	Application.Quit();
            #endif
        }

       
        //Vai al tutorial
        if (Input.GetKeyDown(KeyCode.T) && mainmenucanvas.activeSelf)
        {
            clicksound.Play();
            vignettaCaricamento.SetActive(true);
            SceneManager.LoadScene("Tutorial");
        }


        //go to level 1
        if (Input.GetKeyDown(KeyCode.R) && mainmenucanvas.activeSelf)
        {
            clicksound.Play();
            vignettaCaricamento.SetActive(true);
            SceneManager.LoadScene("OpenWorld");
        }

        /*//vai alle impostazioni
        if (Input.GetKeyDown(KeyCode.S))
        {
            clicksound.Play();
            mainmenucanvas.SetActive(false);
            settingsCanvas.SetActive(true);
        }
        //torna al menu principale
        if (Input.GetKeyDown(KeyCode.B))
        {
            clicksound.Play();
            mainmenucanvas.SetActive(true);
            settingsCanvas.SetActive(false);
        }*/
    }


}