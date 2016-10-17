using UnityEngine;
using System.Collections;

public class GateManager : MonoBehaviour {

    // Use this for initialization
    GameObject ref_obj;
    public GameObject GateOpen;
    SpriteRenderer sprite;
     float distance;
     float angle;


    void Awake()
    {
        //this.transform.Rotate(new Vector3(0.0f, 0.0f, 10.0f));
    }

    // Use this for initialization
    void Start()
    {
        Instantiate(GateOpen, transform.position, transform.rotation);

        ref_obj = GameObject.Find("ScytheImage");

        angle = ref_obj.GetComponent<Slash>().angle;
        distance = ref_obj.GetComponent<Slash>().distance;

        Debug.Log("angle" + angle);

        this.transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, angle * Mathf.Rad2Deg);
        this.transform.localScale = new Vector3(0, distance / 4, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
