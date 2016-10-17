using UnityEngine;
using System.Collections;

public class ResultManager : MonoBehaviour
{
    [SerializeField]
    private GameObject AAction;
    [SerializeField]
    private GameObject BAction;
    [SerializeField]
    private GameObject CAction;
    [SerializeField]
    private GUIText scoreGUI;
    [SerializeField]
    private GUIText rankGUI;
    [SerializeField]
    private rankingScript ranking;

    private int gameRank;
    // Use this for initialization
    void Awake ()
    {
        AAction.SetActive(false);
        BAction.SetActive(false);
        CAction.SetActive(false);
        if (scoreScript.score < 500)
            gameRank = 0;
        else if (scoreScript.score < 1000)
            gameRank = 1;
        else if (scoreScript.score < 1500)
            gameRank = 2;
    }

    void Start()
    {
        if (gameRank == 2)
        {
            AAction.SetActive(true);
            rankGUI.text = "A";
        }
        if (gameRank == 1)
        {
            BAction.SetActive(true);
            rankGUI.text = "B";
        }
        if (gameRank == 0)
        {
            CAction.SetActive(true);
            rankGUI.text = "C";
        }

        scoreGUI.text = "" + scoreScript.score;

        ranking.SaveRanking(scoreScript.score);
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
