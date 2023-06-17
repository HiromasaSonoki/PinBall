using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (tag == "SmallStarTag")
        {
            score_num += 10;
        }
        else if (tag == "LargeStarTag")
        {
            score_num += 20;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            score_num += 5;
        }
    }
}
