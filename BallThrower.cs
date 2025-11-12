using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    // 投げる力
    public float throwPower = 10f;
    // Prefabを格納する変数
    public GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたら
        if(Input.GetKeyDown(KeyCode.Space))
        {
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

            // 前方向に力を加える
            // transform.forward このオブジェクトの前方向
            // throwPower 投げる力
            // ForceMode.Impulse 瞬間的に力を加える
            .AddForce(
                transform.forward * throwPower,
                ForceMode.Impulse
            );
        }
    }
}
