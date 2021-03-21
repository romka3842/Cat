using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_menu : MonoBehaviour
{
    [SerializeField] GameObject PausePlane;
    [SerializeField] GameObject MusicButton;
    AudioSource sceneMusic;


    private void Start()
    {
        sceneMusic = GetComponent<AudioSource>();
        sceneMusic.Play();
        
    }
    public void OnClickPause()
    {
        PausePlane.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnClickBack()
    {
        PausePlane.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnClickExit()
    {
        Application.Quit();
    }


}
