using UnityEngine;
using System.Collections;

public class heavenScript : MonoBehaviour
{
    public GameObject play;

    void Awake()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="soul")
        {

            Destroy(other.gameObject);

            playManager.player_tension -= 1.0f;
        }
    }
}
