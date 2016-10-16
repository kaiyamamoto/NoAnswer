using UnityEngine;
using System.Collections;

public class Slash : MonoBehaviour
{
    public Vector2 start_point;
    public Vector2 end_point;
    public SpriteRenderer sprite;
    public float angle;
    public GameObject gate;
    public float distance;
    public float spend_guage;
    public int rotate_state;
    float scythe_angle = 0.0f;


    void Awake()
    {
        Debug.Log("主ラッシュのアウェイクが実行されました");
    }


    // Use this for initialization
    void Start()
    {
        Debug.Log("スラッシュのスタートが実行されました");
        sprite = GetComponent<SpriteRenderer>();
        GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        var color = sprite.color;
        // 鎌実体化
        color.a = 1.0f;

        // キーを押した瞬間、始点を取得
        if (Input.GetMouseButtonDown(0))
        {
            //マウスのx,y座標を取得
            Vector2 vecMouse = Input.mousePosition;
            //ワールド座標に変換
            Vector2 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
            // 始点座標を決定
            start_point = screenPos;

            // 回転状態変更
            rotate_state = 1;
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
            angle = Mathf.Atan2(end_point.x - start_point.x, start_point.y - end_point.y);

            // 距離の算出
            distance = Vector2.Distance(start_point, end_point);
            //   Debug.Log("distance = " + distance);

        }

        if (distance < 1.0f || distance > 3.5f || GageControll.limit <= distance * 0.15f)
        {
            color.a = 0.20f;
            if (!(Input.GetMouseButton(0)))
            {
                color.a = 1.0f;
            }
        }
        else
        {
            color.a = 1.0f;
        }

        // スプライトの透明度を設定
            sprite.color = color;

            // キーを離した瞬間、終点を取得し、オブジェクトを生成
            if (Input.GetMouseButtonUp(0))
            {
                // オブジェクトの生成
                Vector2 obj_pos;
                obj_pos.x = start_point.x + (end_point.x - start_point.x) / 2;
                obj_pos.y = start_point.y + (end_point.y - start_point.y) / 2;

                if ((distance >= 1.0f && distance <= 3.5f ) && GageControll.limit > distance * 0.15f)
                {
                    Instantiate(gate, obj_pos, Quaternion.identity);

                    // ゲージの消費量を設定
                    spend_guage = distance * 0.15f;
                }
                else
                {
                    spend_guage = 0;
                }


            rotate_state = 2;
            


        }

        switch (rotate_state)
        {
            case 1:
                if(scythe_angle < 90.0f)
                {
                    scythe_angle += 5.0f;
                }

                break;
            case 2:
                if (scythe_angle > 0.0f)
                {
                    scythe_angle -= 5.0f;
                }
                break;
        }
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, scythe_angle);
    }
}
