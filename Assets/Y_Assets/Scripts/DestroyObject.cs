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
        ref_obj = GameObject.Find("Scythe");
        distance = ref_obj.GetComponent<Slash>().distance;
        life_time = 5.0f - distance;
        alive_time = 0;
        scale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        alive_time += 0.01f;

        if (alive_time > life_time)
        {
            Destroy(this.gameObject);
        }

        // スプライトの拡大

        if (this.transform.localScale.x <= distance/4 * 0.7f)
        {
            Vector3 spread = this.transform.localScale;
            spread.Set(transform.localScale.x + 0.1f, transform.localScale.y, transform.localScale.z);
            transform.localScale = spread;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "soul")
        {
            Debug.Log("hit!!");

            Destroy(other.gameObject);
        }
    }
}
