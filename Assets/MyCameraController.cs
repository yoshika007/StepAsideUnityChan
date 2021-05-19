using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //ユニティちゃんとカメラの距離
    private float difference;


    // Start is called before the first frame update
    void Start()
    {
        //ユニティちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //ユニティちゃんとカメラの位置（z座標）を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //ユニティちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);



    }
}
