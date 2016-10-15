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

            playManager p_manager = play.GetComponent<playManager>();
            p_manager.player_tension -= 1.0f;
            if(p_manager.player_tension<0.0f)
            {
                GameObject.Find("PlayManager").SendMessage("GameFinish");
            }
        }
    }
}
