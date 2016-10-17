using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void GameTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void GamePlay()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void GameRanking()
    {
        SceneManager.LoadScene("RankingScene");
    }

    public void GameResult()
    {
        SceneManager.LoadScene("ResultScene");
    }

    public void KeySave()
    {
        // キーと値を保存
        PlayerPrefs.Save();
    }

    public void KeyReset()
    {
        // キーを全て消す
        PlayerPrefs.DeleteAll();
    }

}
