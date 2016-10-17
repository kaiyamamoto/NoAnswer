using UnityEngine;
using System.Collections;

public class Transparent : MonoBehaviour {

    public SpriteRenderer GateOpen;
    // Use this for initialization
    void Start () {
        GateOpen = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        var color = GateOpen.color;
        // 鎌実体化
        color.a = 0.0f;
    }
}
