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
        GameObject.Find("ScoreGUI").SendMessage("Save");
        SceneManager.LoadScene("ResultScene");
    }
}
