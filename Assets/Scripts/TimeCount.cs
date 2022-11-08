using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    //[SerializeField]
    //[Tooltip("��")]
    //private int minute;

    //[SerializeField]
    //[Tooltip("�b")]
    //private float seconds;

    //[SerializeField]
    //[Tooltip("���ԕ\���p�e�L�X�g")]
    //private Text timeText;

    [SerializeField]
    private GameObject ResultPanel;

    [SerializeField]
    private AudioSource GameBGM;

    [SerializeField]
    private AudioSource ResultBGM;

    //private float totalTime;
    //private float oldSeconds;
    public bool finFlag;

    // Start is called before the first frame update
    void Start()
    {
        //totalTime = minute * 60 + seconds;
        //oldSeconds = 0.0f;
        ResultPanel.SetActive(false);
        finFlag = false;
        ResultBGM.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        ////�@�������Ԃ�0�b�ȉ��Ȃ牽�����Ȃ�
        //if (totalTime <= 0f)
        //{
        //    return;
        //}

        ////�@�g�[�^���̐������Ԃ��v���G
        //totalTime = minute * 60 + seconds;
        //totalTime -= Time.deltaTime;

        ////�@���Ԃ��Đݒ�
        //minute = (int)totalTime / 60;
        //seconds = totalTime - minute * 60;

        //// ���Ԃ�\��
        //if ((int)seconds != (int)oldSeconds)
        //{
        //    timeText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        //}

        //oldSeconds = seconds;

        //// �O�b�ȉ��ɂȂ�����I��
        //if (totalTime <= 0.0f)
        //{
        //    Debug.Log("�I��");
        //    ResultPanel.SetActive(true);
        //    timeText.enabled = false;
        //    finFlag = true;
        //}

        if (finFlag == true)
        {
            GameBGM.Stop();
            ResultPanel.SetActive(true);
            ResultBGM.Play();

            // ResultBGM�̍Đ��̕s����o���̂ŁA�������߂̉��}���u
            finFlag = false;
        }
    }
}