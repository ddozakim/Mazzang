using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    private AudioSource theAudio;
    [SerializeField] private AudioClip[] clip;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    public void Play()
    {
        int temp = Random.Range(0, 1);
        theAudio.clip = clip[temp];
        theAudio.Play();
    }
}
