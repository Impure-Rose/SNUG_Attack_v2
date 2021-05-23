using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMainMenu : MonoBehaviour
{

    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Play()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SNUG_Feild");
        Time.timeScale = 1;
    }
    IEnumerator LoadSceneAsync()
    {
        
        yield return null;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {

    }
    public void Resume()
    {
        player.GetComponent<PlayerCharacter>().paused = false;
        player.GetComponent<PlayerCharacter>().pauseMenu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Menu()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Menu");
    }
}
