using UnityEngine;
using System.Collections;

public class Fever : MonoBehaviour
{

    bool isFever_flag = DestroyMyObj.isFever_flag;

    public AudioClip Nomal;
    public AudioClip Hitension;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        if (DestroyMyObj.fever_time > 0)
        {
            DestroyMyObj.fever_time--;
            audioSource.clip = Hitension;
        }
        else
        {
            isFever_flag = false;
            audioSource.clip = Nomal;
        }

        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
