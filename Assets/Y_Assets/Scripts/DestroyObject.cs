using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

    public float life_time;
    public float alive_time;
    public float distance;
    GameObject refObj;

	// Use this for initialization
	void Start () {
        refObj = GameObject.Find("Scythe");
        distance = refObj.GetComponent<Slash>().distance;
        life_time = 5.0f - distance;
        alive_time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        alive_time += 0.01f;

        if(alive_time > life_time)
        {
            Destroy(this.gameObject);
        }
	}
}
