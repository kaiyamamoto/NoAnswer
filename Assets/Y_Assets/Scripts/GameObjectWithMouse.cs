using UnityEngine;
using System.Collections;

public class GameObjectWithMouse : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        //マウスのx,y座標を取得
        Vector2 vecMouse = Input.mousePosition;

        vecMouse.x -= 3.0f;
        //ワールド座標に変換
        Vector2 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
        //オブジェクトに代入
        transform.position = screenPos;
    }
}
