using UnityEngine;
using System.Collections;

public class DestroyMyObj : MonoBehaviour {
    public float life_time;
    public float alive_time;
    public float distance;
    public float scale;
    GameObject ref_obj;
    GameObject ref_obj2;
    GameObject obj;
    public static bool isFever_flag = false;
    public static float fever_time;

    // Use this for initialization
    void Start()
    {
        ref_obj = GameObject.Find("ScytheImage");
        ref_obj2 = GameObject.Find("GateOpen");
        distance = ref_obj.GetComponent<Slash>().distance;

        life_time = 5.0f - distance;
        alive_time = 0;
        scale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        alive_time += 0.01f;

        // スプライトの縮小
        if (alive_time > life_time)
        {
            Vector3 shorten = this.transform.localScale;
            shorten.Set(transform.localScale.x - 0.05f, transform.localScale.y, transform.localScale.z);
            transform.localScale = shorten;
        }

        // スプライトの拡大
        else if (this.transform.localScale.x <= distance / 4 * 0.7f)
        {
            Vector3 spread = this.transform.localScale;
            spread.Set(transform.localScale.x + 0.05f, transform.localScale.y, transform.localScale.z);
            transform.localScale = spread;
        }
        // スプライトの消滅
        if (this.transform.localScale.x < 0)
        {
            Destroy(this.gameObject);
            Destroy(ref_obj2.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "soul")
        {
            fever_time += 5.0f;
            Debug.Log("hit!!");
            GameObject.Find("ScoreGUI").SendMessage("AddScore", 10);

            Destroy(other.gameObject);
            if (other.gameObject.name == "Rainbowsoul")
            {
                isFever_flag = true;
                fever_time += 5.0f;
            }
        }
    }
}
