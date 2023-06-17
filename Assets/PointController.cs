using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public GameObject score_object = null; // Text�I�u�W�F�N�g
    public int score_num = 0; // �X�R�A�ϐ�

    // ������
    void Start()
    {
    }

    // �X�V
    void Update()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
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
