using UnityEngine;
using System.Collections;

public class playManager : MonoBehaviour
{
    public GameObject soul_prefab;
    public GameObject tension_soul;
    public GameObject rainbow_soul;
    public float waiting_time = 1.0f;
    public static float player_tension = 10.0f;
	

    void Awake()
    {
        player_tension = 10.0f;
    }
	void Start ()
    {
        InvokeRepeating("Create", waiting_time, waiting_time);
    }

    void Update()
    {
        if (playManager.player_tension <= 0.0f) 
        {
            Debug.Log("finish");
            GameObject.Find("PlayManager").SendMessage("GameResult");
        }
    }

    void Create()
    {
        int soul_pop = Random.Range(0, 100);

        if(soul_pop==0)
            Instantiate(rainbow_soul, new Vector3(Random.Range(-2.0f, 2.0f), -5.5f), Quaternion.identity);
        else if(soul_pop%10==0)
            Instantiate(tension_soul, new Vector3(Random.Range(-2.0f, 2.0f), -5.5f), Quaternion.identity);
        else
            Instantiate(soul_prefab,new Vector3(Random.Range(-2.0f,2.0f),-5.5f), Quaternion.identity);
    }
}
