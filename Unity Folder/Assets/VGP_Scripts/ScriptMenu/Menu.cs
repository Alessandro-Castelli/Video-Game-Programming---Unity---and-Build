using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject vignettaCaricamento;
    public GameObject settingsCanvas;
    public GameObject mainmenucanvas;
    public AudioSource click;
    private int score;

    public AudioMixer audioMixer; // Assegna l'Audio Mixer nell'Editor Unity.
    private bool isMuted = false; // Stato del muto.

    private void Start()
    {

        vignettaCaricamento.SetActive(false);
        settingsCanvas.SetActive(false);
        mainmenucanvas.SetActive(true);
        score = PlayerPrefs.GetInt("Score1", 0);

    }
    void Update()
    {
        //esci dal gioco
        if (Input.GetKeyDown(KeyCode.Q) && mainmenucanvas.activeSelf)
        {
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.Save();
            click.Play();
            Time.timeScale = 1f;
            vignettaCaricamento.SetActive(true);

            backToOpenWorld.giaGiocatoL1 = false;
            OpenDoor2.giaGiocatoL2 = false;
            EndL3.giaGiocatoL3 = false;

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
	        	Application.Quit();
#endif
        }

        // riavvia livello

        if (Input.GetKeyDown(KeyCode.R) && mainmenucanvas.activeSelf)
        {

            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.Save();
            click.Play();
            Time.timeScale = 1f;
            vignettaCaricamento.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            // Verifica se il tasto "M" è stato premuto.
            if (Input.GetKeyDown(KeyCode.M))
            {
                // Inverti lo stato del muto.
                isMuted = !isMuted;

                click.Play();

                // Ottieni tutti gli AudioSource nella scena.
                AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

                // Itera attraverso tutti gli AudioSource e abilita/disabilita l'opzione "mute".
                foreach (AudioSource audioSource in allAudioSources)
                {
                    audioSource.mute = isMuted;
                }
            }
        }

        /*if (Input.GetKeyDown(KeyCode.T))
        {
            vignettaCaricamento.SetActive(true);
            SceneManager.LoadScene("Tutorial");

        }*/


        //go to settings
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            click.Play();
            mainmenucanvas.SetActive(false);
            settingsCanvas.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            click.Play();
            mainmenucanvas.SetActive(true);
            settingsCanvas.SetActive(false);
        }*/
    }


}