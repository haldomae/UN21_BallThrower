using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    // 投げる力
    public float throwPower = 10f;
    // Prefabを格納する変数
    public GameObject ballPrefab;

    // 上の力
    public float upwardPower = 8f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたら
        // if(Input.GetKeyDown(KeyCode.Space))
        // 0 左クリック
        // 1 右クリック
        // 2 中クリック
        if(Input.GetMouseButton(0))
        {
            // マウス位置への方向を取得
            Ray ray = Camera.main.ScreenPointToRay(
                Input.mousePosition
            );
            Vector3 clickDirection = ray.direction;


            // ボールの位置を決める(3D座標)
            // GameManagerの位置
            Vector3 ballPosition = transform.position;

            // ボール複製
            GameObject ball = Instantiate(
                // 1. Prefab(元となるもの)
                ballPrefab,
                // 2. 生成位置(3D座標)
                ballPosition,
                // 3. 生成時の回転
                Quaternion.identity
            );

            // 複製されたボールのRigidbodyコンポーネントを取得
            Rigidbody rb = ball.GetComponent<Rigidbody>();

            // 前方向に力を加える
            // transform.forward このオブジェクトの前方向
            // throwPower 投げる力
            // ForceMode.Impulse 瞬間的に力を加える
            // rb.AddForce(
            //     transform.forward * throwPower,
            //     ForceMode.Impulse
            // );
            // // 上方向に力を加える
            // rb.AddForce(
            //     Vector3.up * upwardPower,
            //     ForceMode.Impulse
            // );
            rb.velocity = clickDirection * throwPower;

            // 3秒後に削除
            Destroy(ball, 3f);
        }
    }
}
