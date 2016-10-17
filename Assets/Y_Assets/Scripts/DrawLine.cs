using UnityEngine;
using System.Collections;

public class DrawLine : MonoBehaviour
{
    public LineRenderer linerenderer;
    public GameObject ref_obj;

    public Vector2 start_point;
    public Vector2 end_point;
    public float length;

    // Use this for initialization

    void Start()
    {
        ref_obj = GameObject.Find("ScytheImage");
        linerenderer = gameObject.GetComponent<LineRenderer>();

        // 線の幅
        linerenderer.SetWidth(0.03f, 0.03f);
        // 頂点の数
        linerenderer.SetVertexCount(2);

        // 線の長さ
        length = ref_obj.GetComponent<Slash>().distance;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            linerenderer = gameObject.GetComponent<LineRenderer>();
        }

        if (Input.GetMouseButton(0))
        {
            start_point = ref_obj.GetComponent<Slash>().start_point;
            end_point = ref_obj.GetComponent<Slash>().end_point;
            // 頂点を設定
            linerenderer.SetPosition(0, new Vector3(start_point.x, start_point.y, 0));
            linerenderer.SetPosition(1, new Vector3(end_point.x, end_point.y, 0));
        }

        if (Input.GetMouseButtonUp(0))
        {
            linerenderer.SetPosition(0, new Vector3(0, 0, 0));
            linerenderer.SetPosition(1, new Vector3(0, 0, 0));
            //Destroy(linerenderer);
        }
    }
}
