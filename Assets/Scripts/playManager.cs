using UnityEngine;
using System.Collections;

public class playManager : MonoBehaviour
{
    public GameObject soul_prefab;

    public float waitingTime = 2.0f;
	
	// Update is called once per frame
	void Awake ()
    {
        InvokeRepeating("Create", waitingTime, waitingTime);
    }

    void Create()
    {
        Instantiate(soul_prefab,new Vector3(Random.Range(-2.0f,2.0f),-5.5f), Quaternion.identity);
    }
}
