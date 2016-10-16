using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GageControll : MonoBehaviour {

    public static float limit = 1.0f;
    Slider slider;
    GameObject ref_obj;

    void Awake()
    {
        Debug.Log("ゲージコントロールのアウェイクが実行されました");
    }

    // Use this for initialization
    void Start () {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        ref_obj = GameObject.Find("Scythe");

        Debug.Log("ゲージコントロールのスタートが実行されました");
    }


    float spend_gauge;
    // Update is called once per frame


    void Update()
    {
        //マウスのx,y座標を取得
        Vector2 vecMouse = Input.mousePosition;
        //ワールド座標に変換
        Vector2 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);

        spend_gauge = ref_obj.GetComponent<Slash>().spend_guage;

        if (Input.GetMouseButtonUp(0))
        {
            limit -= spend_gauge;
        }


        if (limit < 1.0f)
        {
            limit += 0.002f;
        }
        slider.value = limit;
        slider.transform.position = vecMouse;

        if (limit < 0)
        {
            limit = 0.0f;
        }
    }
}
