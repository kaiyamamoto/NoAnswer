using UnityEngine;
using System.Collections;

public class soulScript : MonoBehaviour
{
    // 移動スピード
    private float speed_x;
    private float speed_y;

    void Awake()
    {
        // 速度設定
        //speed_x = Random.Range(-10.0f, 10.0f);
        //speed_y = Random.Range(5.0f, 10.0f);

        speed_x = 10.0f;
        speed_y = 10.0f;
    }

    void Update()
    {
        // 移動
        Move();

        GetComponent<Rigidbody2D>().WakeUp();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag=="Screen")
        {
            speed_x *= -1.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gate")
        {
            Destroy(this.gameObject);
        }
    }

    // 移動
    public void Move()
    {
        this.transform.position += new Vector3(speed_x * Time.deltaTime, speed_y * Time.deltaTime, 0.0f);
    }
}
