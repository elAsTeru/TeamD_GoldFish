using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoiMG : MonoBehaviour
{
    private float mTime;
    private bool ScoopFlag;

    public Chase mChase;
    public Animator mAnim;
    public Animator mAnim2;
    public CatchScript mCatch;

    /// <summary>
    /// ������
    /// </summary>
    void Start()
    {
        mTime = 0.0f;
    }

    /// <summary>
    /// �X�V
    /// </summary>
    void Update()
   {
        mCatch.CatchUpdate();

        if (ScoopFlag)
        { 
            ScoopFlag = false;
            mChase.agent.speed = 15.0f;
            mTime += Time.deltaTime;
            if(mTime >= 15.0f)
            {
                mTime = 0.0f;
                // �^�[�Q�b�g�������_���ŕύX����
                mChase.target = mChase.Players[Random.Range(0, mChase.Players.Length)].transform;
            }
        }
        else
        {
            mChase.ChaseUpdate();
        }
    }

    /// <summary>
    /// �R���C�_�[�ɓ�������
    /// </summary>
    /// <param name="other">�R���C�_�[</param>
    private void OnTriggerEnter(Collider other)
    {
        // �^�O���wPlayer�x�ł�������
        if (transform.parent == null && other.tag == "Player" && !ScoopFlag)
        {
            ScoopFlag = true;
            var empty = new GameObject();
            empty.transform.parent = other.gameObject.transform;
            mAnim.SetBool("scoop", true);
            mAnim2.SetBool("scoop", true);
        }
        else
        {
            mAnim.SetBool("scoop", false);
            mAnim2.SetBool("scoop", false);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        // �^�O���wPlayer�x�ł�������
        if (transform.parent != null && other.tag == "Player")
        {
            transform.parent = null;
            //mAnim.SetBool("scoop", false);
            //mAnim2.SetBool("scoop", false);
        }
    }
}


