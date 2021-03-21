using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{
    [SerializeField] Sprite musicOn_sprite;
    [SerializeField] Sprite musicOff_sprite;
    [SerializeField] AudioSource sceneMusic;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        print("Push");
        if (sceneMusic.mute == false)
        {
            GetComponent<SpriteRenderer>().sprite = musicOff_sprite;
            sceneMusic.mute = true;
            print("Music is switch off");
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = musicOn_sprite;
            sceneMusic.mute = false;
        }
    }
}
