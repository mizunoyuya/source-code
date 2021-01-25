using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Destroy : MonoBehaviour

{

    public int point;

    public GameObject cube;

    private float time;

    private bool count;



    // Use this for initialization

    void Start()

    {

        time = 0;

        count = false;　//最初はCountがfalseの状態

    }



    // Update is called once per frame

    void Update()

    {

        if (count)

        {　//countがtrueの時は時間が進む

            time += Time.deltaTime;





            if (time >= 1)

            {//１秒を超えるとcubeは消える

                Destroy(cube);
                //スコア処理を追加
                FindObjectOfType<Score>().AddPoint(point);


            }





        }

    }



    //後ほどEventTriggerへ設定、視点がオブジェクトに乗ったら

    public void OnEnterPointer()

    {

        count = true;　//カウントがtrueに

    }



    //視点がオブジェクトから外れたら

    public void OnExitPonter()

    {

        count = false;//カウントがfalseにtimeが0に

        time = 0;

    }



}