using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour
{

    public float life_time;
    public float alive_time;
    public float distance;
    public float scale ;
    GameObject ref_obj;

    // Use this for initialization
    void Start()
    {
        ref_obj = GameObject.Find("ScytheImage");
        distance = ref_obj.GetComponent<Slash>().distance;
        life_time = 5.0f - distance;
        alive_time = 0;
        scale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        alive_time += 0.01f;

        // スプライトの拡大


        if (alive_time > life_time)
        {
            Vector3 shorten = this.transform.localScale;
            shorten.Set(transform.localScale.x - 0.05f, transform.localScale.y, transform.localScale.z);
            transform.localScale = shorten;
        }
        else if (this.transform.localScale.x <= distance / 4 * 0.7f)
        {
            Vector3 spread = this.transform.localScale;
            spread.Set(transform.localScale.x + 0.05f, transform.localScale.y, transform.localScale.z);
            transform.localScale = spread;
        }



        if (this.transform.localScale.x < 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "soul")
        {
            Debug.Log("hit!!");
            GameObject.Find("ScoreGUI").SendMessage("AddScore", 10);

            Destroy(other.gameObject);
        }
    }
}
