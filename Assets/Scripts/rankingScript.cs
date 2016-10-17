using UnityEngine;
using System.Collections;

public class rankingScript : MonoBehaviour
{
    public static int[] highScore = new int[5];

    [SerializeField]
    private GUIText score_1stGUI;
    [SerializeField]
    private GUIText score_2ndGUI;
    [SerializeField]
    private GUIText score_3rdGUI;
    [SerializeField]
    private GUIText score_4thGUI;
    [SerializeField]
    private GUIText score_5thGUI;

    void Awake()
    {
        GetRanking();
    }

    void Start()
    {
        SaveRanking(scoreScript.score);
    }

    void GetRanking()
    {
        string ranking = PlayerPrefs.GetString("Ranking");
        if (ranking.Length > 0)
        {
            string[] score = ranking.Split(","[0]);
            highScore = new int[5];
            for (int i = 0; i < score.Length && i < 5; i++)
            {
                highScore[i] = int.Parse(score[i]);
            }
        }
    }

    public void SaveRanking(int new_score)
    {
        if (highScore[0] != 0)
        {
            int tmp = 0;
            for (int i = 0; i < highScore.Length; i++)
            {
                if (highScore[i] < new_score)
                {
                    tmp = highScore[i];
                    highScore[i] = new_score;
                    new_score = tmp;
                }
            }
        }
        else
        {
            highScore[0] = new_score;
        }
        string ranking_str = string.Join(",", System.Array.ConvertAll<int, string>(highScore, (int v) => { return v.ToString(); }));
        PlayerPrefs.SetString("Ranking", ranking_str);

        score_1stGUI.text = "" + highScore[0];
        score_2ndGUI.text = "" + highScore[1];
        score_3rdGUI.text = "" + highScore[2];
        score_4thGUI.text = "" + highScore[3];
        score_5thGUI.text = "" + highScore[4];
    }
}
