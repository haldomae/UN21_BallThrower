using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    // 投げる力
    float throwPower = 10f;
    // Rigidbodyのコンポーネントを格納する変数
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // コンポーネントを取得
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたら
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 前方向に力を加える
            // transform.forward このオブジェクトの前方向
            // throwPower 投げる力
            // ForceMode.Impulse 瞬間的に力を加える
            rb.AddForce(
                transform.forward * throwPower,
                ForceMode.Impulse
            );
        }
    }
}
