using UnityEngine;
using System.Collections;

public class SwitchFace : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite HighSprite;
    public Sprite NomalSprite;
    public Sprite LowSprite;

    float player_tension;

    void Awake()
    {

    }

    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // 何かしらのタイミングで呼ばれる
    void Update()
    {
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        // 例) HoldSpriteに変更

        if (playManager.player_tension >= 8 || DestroyMyObj.isFever_flag)
            MainSpriteRenderer.sprite = HighSprite;
        else if (playManager.player_tension >= 4)
            MainSpriteRenderer.sprite = NomalSprite;
        else
            MainSpriteRenderer.sprite = LowSprite;

    }
}