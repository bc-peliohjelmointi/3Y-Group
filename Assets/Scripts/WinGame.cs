using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    public GameObject winPanel;

    public GameObject mainMenuButton;

    public AudioManager AM;

    public GameObject objective;



    // Start is called before the first frame update
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {

        


    }

    public void winGame()
    {

        winPanel.SetActive(true);

        mainMenuButton.SetActive(true);

        objective.SetActive(false);

        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;

        AM.PlayWinMusic();

    }


    public void mainMenu()
    {

        Time.timeScale = 1f;

        SceneManager.LoadScene(0);


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("WinGame"))
        {

            winGame();

        }

    }







}
