using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player01hate : MonoBehaviour
{
    [SerializeField]
    int add = 0;

    [SerializeField]
    Text player01text;

    [SerializeField]
    Text player02text;


    int NowPlayer01;
    int NowPlayer02;




    public void Awake()
    {
        NowPlayer01 = 0;
        NowPlayer02 = 0;

    }

    bool CountUpFlag = false;

    //�w�C�g���オ��֐�
    //�オ��w�C�g�̐��l�ƃw�C�g���オ��v���C���[�i���o�[����������ɂ���
    public void HateUp(int addHate,int NumPlayer)
    {
        //�w�C�g���オ��v���C���[���񂪂P�̏ꍇ
        if(NumPlayer�@== 1)
        {
            NowPlayer01 += addHate;
            player01text.text = NowPlayer01.ToString();

            NowPlayer01 += add;
            player01text.text = NowPlayer01.ToString();


        }
        else if(NumPlayer == 2) //�w�C�g���オ��v���C���[���񂪂Q�̏ꍇ
        {
            NowPlayer02 += addHate;
            player02text.text = NowPlayer02.ToString();

        }

    }
    //�w�C�g��������
    public void HateDown(int DownHate, int NumPlayer)
    {
        //�w�C�g���オ��v���C���[���񂪂P�̏ꍇ
        if (NumPlayer == 1)
        {
            NowPlayer01 -= DownHate;
            //�w�C�g�̐��l���}�C�i�X��������0�ɂ���
            if(NowPlayer01 < 0)
            {
                NowPlayer01 = 0;
            }
            player01text.text = NowPlayer01.ToString();

        }
        else if (NumPlayer == 2) //�w�C�g���オ��v���C���[���񂪂Q�̏ꍇ
        {
            NowPlayer02 -= DownHate;
            //�w�C�g�̐��l���}�C�i�X��������0�ɂ���
            if (NowPlayer02 < 0)
            {
                NowPlayer02 = 0;
            }
            player02text.text = NowPlayer02.ToString();

        }

    }

    public void BucketHidden()
    {
    }
}
