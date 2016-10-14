using UnityEngine;
using System.Collections;

public class Slash : MonoBehaviour
{
    private Vector2 start_point;
    private Vector2 end_point;
    public float angle;
    public GameObject gate;
    public float distance;


    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
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



        if (Input.GetMouseButton(0))
        {
            //マウスのx,y座標を取得
            Vector2 vecMouse = Input.mousePosition;
            //ワールド座標に変換
            Vector2 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
            // 始点座標を決定
            end_point = screenPos;

            // 角度を計算
            angle = Mathf.Atan2( end_point.x - start_point.x ,   start_point.y-end_point.y);

            // 距離の算出
            distance = Vector2.Distance(start_point, end_point);

            Debug.Log("distance = " + distance);

        }



        // キーを離した瞬間、終点を取得し、オブジェクトを生成
        if (Input.GetMouseButtonUp(0))
        {
            // オブジェクトの生成
            Vector2 obj_pos;
            obj_pos.x = start_point.x +(end_point.x - start_point.x) / 2;
            obj_pos.y = start_point.y +(end_point.y - start_point.y) / 2;
            Instantiate(gate, obj_pos, Quaternion.identity);
        }
    }
}
