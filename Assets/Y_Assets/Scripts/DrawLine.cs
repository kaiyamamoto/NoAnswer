using UnityEngine;
using System.Collections;

public class DrawLine : MonoBehaviour
{

    public LineRenderer linerenderer;
    public GameObject ref_obj;

    public Vector2 start_point;
    public Vector2 end_point;

    // Use this for initialization

    void Awake()
    {
       
    }
    void Start()
    {
        ref_obj = GameObject.Find("Scythe");
        linerenderer = gameObject.GetComponent<LineRenderer>();

        start_point = ref_obj.GetComponent<Slash>().start_point;
        end_point = ref_obj.GetComponent<Slash>().end_point;

        // 線の幅
        linerenderer.SetWidth(0.1f, 0.1f);
        // 頂点の数
        linerenderer.SetVertexCount(2);
    }

    // Update is called once per frame
    void Update()
    {
        // 線の幅
        linerenderer.SetWidth(0.1f, 0.1f);
        // 頂点の数
        linerenderer.SetVertexCount(2);

        if (Input.GetMouseButton(0))
        {
            // 頂点を設定
            linerenderer.SetPosition(0, start_point);
            linerenderer.SetPosition(1, end_point);
        }
        else
        {
           // Destroy(linerenderer.gameObject);
        }
    }
}
