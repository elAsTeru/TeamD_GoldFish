using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerStamina : MonoBehaviour
{
    //�v���C���[�P�̃X�^�~�i�Q�[�W
    [SerializeField]
    Image image1;
    //�v���C���[�Q�̃X�^�~�i�Q�[�W
    [SerializeField]
    Image image2;

    //�X�^�~�i���������
    [SerializeField]
    float StaminaIncrease;
    //�X�^�~�i�������
    [SerializeField]
    float StaminaDiminish1;

    int LoseStaminaFlag;

    private void Awake()
    {
        LoseStaminaFlag =0;
    }

    // Start is called before the first frame update
    void Update()
    {

    }

    public void StaminaDown(float DownStamina, int PlayerNum)
    {

        
        //�X�^�~�i�����鏈�������Ă�����X�^�~�i������
        //if (LoseStaminaFlag > 0)
        {
            //playerNum�͍U�����󂯂���
            if (PlayerNum == 1)
            {
                //�U�����󂯂���X�^�~�i����萔����
                image1.fillAmount -= DownStamina * Time.deltaTime;

            }
            else if (PlayerNum == 2)
            {
                image2.fillAmount -= DownStamina * Time.deltaTime;
            }

        }

    }

    public void StaminaUp(float UpStamina, int PlayerNum)
    {
        //�X�^�~�i�����鏈�������Ă��Ȃ�������X�^�~�i��������
        //if (!LoseStaminaFlag)
        {
            //playerNum�͍U�����󂯂���
            if (PlayerNum == 1)
            {
                //�U�����󂯂���X�^�~�i����萔����
                image1.fillAmount += UpStamina * Time.deltaTime;
            }
            else if (PlayerNum == 2)
            {
                image2.fillAmount += UpStamina * Time.deltaTime;
            }

        }


    }

}
