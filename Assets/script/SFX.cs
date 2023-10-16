using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{

    //Audio Variable
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip bewm;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Big BEWM space press
        if(Input.GetKeyUp(KeyCode.Space) && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(bewm);
        }

    }
}
