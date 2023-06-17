using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    private PointController pointController;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        pointController = GameObject.Find("ScoreManager").GetComponent<PointController>();
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag") 
        {
            pointController.score_num += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            pointController.score_num += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            pointController.score_num += 5;
        }
    }
}
