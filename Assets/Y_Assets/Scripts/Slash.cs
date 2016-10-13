using UnityEngine;
using System.Collections;

public class Slash : MonoBehaviour {
    private Vector2 start_point;
    private Vector2 end_point;

    [SerializeField]
    private GameObject gate;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        // キーを押した瞬間、始点を取得
        if (Input.GetMouseButtonDown(0))
        {
            //マウスのx,y座標を取得
            Vector2 vecMouse = Input.mousePosition;
            //ワールド座標に変換
            Vector2 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
            // 始点座標を決定
            start_point = screenPos;
        }

        // キーを離した瞬間、終点を取得し、オブジェクトを生成
        if (Input.GetMouseButtonUp(0))
        {
            //マウスのx,y座標を取得
            Vector2 vecMouse = Input.mousePosition;
            //ワールド座標に変換
            Vector2 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
            // 始点座標を決定
            end_point = screenPos;

            // 角度を計算
            float angle = Mathf.Atan2(start_point.x - end_point.x, start_point.y - end_point.y);



            // オブジェクトの生成
            Instantiate(gate, start_point,Quaternion.identity);

             //transform.rotation = (0, 0, angle);

        }
    }
}
