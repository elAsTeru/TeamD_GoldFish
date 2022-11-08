using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchScript : MonoBehaviour
{
    private bool mCatchFlag;
    private float mTime;

    public GameObject mPanel1;
    public GameObject mPanel2;
    private GameObject mPanel;
    public Chase mChase;

    /// <summary>
    /// ������
    /// </summary>
    void Start()
    {
        mPanel = GetComponent<GameObject>();
        mCatchFlag = false;
        mTime = 3.0f;
    }

    /// <summary>
    /// �L���b�`�X�V
    /// </summary>
    public void CatchUpdate()
    {
        // �t���O���^�̂Ƃ�
        if(mCatchFlag)
        {
            // ���Ԃ����炷
            mTime -= Time.deltaTime;
            if (mTime <= 0.0f)
            {
                mPanel.SetActive(true);
            }
        }
        else
        {
            mTime = 3.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mCatchFlag = true;
            if(mChase.Players[0])
            {
                mPanel = mPanel2;
            }
            if (mChase.Players[1])
            {
                mPanel = mPanel1;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mCatchFlag = false;
        }
    }
}
