using UnityEngine;
using System.Collections;
using DG.Tweening;

public class gageMaskScript : MonoBehaviour
{
    public RectTransform offset;
    public RectTransform mask;

    public static bool isResult = false;
    private float old_tension;

    void Update()
    {
        if(playManager.player_tension != old_tension)
        {
            GageMove();
        }
        old_tension = playManager.player_tension;

        if (offset.anchoredPosition.x >= 270.0f)
            isResult = true;
    }

    private void GageMove()
    {
        float mask_w = playManager.player_tension * 54.0f;
        float offset_w = 270.0f - mask_w / 2;
        Debug.Log(mask_w);
        Debug.Log(offset_w);

        Sequence _myseq = DOTween.Sequence();
        _myseq.Append(offset.DOAnchorPosX(offset_w, 2.0f));
        _myseq.Join(mask.DOSizeDelta(new Vector2(mask_w, 250.0f), 2.0f));
    }
}
