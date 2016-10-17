using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject rankingUI;
    [SerializeField]
    private GameObject UI;

    [SerializeField]
    public FadeManager fade;

    public void GameTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void GamePlay()
    {
        fade.enableFade = true;
        fade.enableFadeOut = true;
    }

    public void GameRanking(bool isRank)
    {
        if (isRank)
        {
            UI.SetActive(false);
            rankingUI.SetActive(true);
        }
        else
        {
            UI.SetActive(true);
            rankingUI.SetActive(false);
        }
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
