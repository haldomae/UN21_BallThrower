using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // ゲームオブジェクト生成時
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 1フレームごとに呼ばれる
    // Update is called once per frame
    void Update()
    {
        
    }

    // 衝突時
    void OnCollisionEnter(Collision Collision)
    {
        Debug.Log("衝突しました");
    }
}
