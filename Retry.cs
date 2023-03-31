using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour
{
     public Transform Target;
    public GameObject Button;

    public void back()
    {

        Target.transform.position = new Vector3(-0.07f, 0.54f, 2.04f);
     
    }

    public void buttonSound()
    {
        AudioSource audioSource = Button.AddComponent<AudioSource>();
        audioSource.Play();
    }
}
