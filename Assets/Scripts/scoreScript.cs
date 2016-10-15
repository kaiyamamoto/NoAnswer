using UnityEngine;
using System.Collections;

public class scoreScript : MonoBehaviour
{
    public GUIText scoreGUI;
    public GUIText highscoreGUI;
    private int score;
    private int highScore;

    // Use this for initialization
    void Start()
    {
        score = 0;
        // キーを使って値を取得
        // キーがない場合は第二引数の値を取得
        highScore = PlayerPrefs.GetInt("highScoreKey", 0);
    }

    // スコアの加算
    void AddScore(int s)
    {
        score += s;
    }

    // Update is called once per frame
    void Update()
    {
        if (highScore < score)
            highScore = score;

        scoreGUI.text = "" + score;
        highscoreGUI.text = "" + highScore;
    }

    public void Save()
    {
        // メソッドが呼ばれたときのキーと値をセットする
        PlayerPrefs.SetInt("highScoreKey", highScore);
        // キーと値を保存
        PlayerPrefs.Save();
    }

    public void Reset()
    {
        // キーを全て消す
        PlayerPrefs.DeleteAll();
    }
}
