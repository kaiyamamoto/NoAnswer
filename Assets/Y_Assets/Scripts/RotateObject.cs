using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

    GameObject ref_obj;
    float distance;
    float angle; 
    void Awake()
    {
        // Debug.Log("create");

        //this.transform.Rotate(new Vector3(0.0f, 0.0f, 10.0f));
    }

    // Use this for initialization
    void Start()
    {
       ref_obj = GameObject.Find("ScytheImage");

        angle =ref_obj.GetComponent<Slash>().angle;
        distance =ref_obj.GetComponent<Slash>().distance;

        this.transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, angle * Mathf.Rad2Deg);
        this.transform.localScale = new Vector3(0, distance/4, 0.2f);

        //GameObject.Destroy(this);
    }

    // Update is called once per frame
    void Update () {

    }
}
