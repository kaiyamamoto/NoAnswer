using UnityEngine;
using System.Collections;


public class scoreScript : MonoBehaviour
{
    [SerializeField]
    private GUIText score_GUI;
    public static int score;

    // Use this for initialization
    void Start()
    {
        score = 0;
        // キーを使って値を取得
    }

    // スコアの加算
    void AddScore(int s)
    {
        score += s;
    }

    // 0の時非表示その他は表示
    // Update is called once per frame
    void Update()
    {
        score_GUI.text = "" + score;
    }
}
