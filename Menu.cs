using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    AudioSource music;
    private void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickExit()
    {
        Application.Quit();
    }
}
