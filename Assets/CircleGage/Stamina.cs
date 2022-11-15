using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    [Header("Gage Setting")]
    [Tooltip("�Q�[�W�Ƃ��ĉғ�����Image�R���|�[�l���g")][SerializeField]Image gageImg;
    [Tooltip("�Ώۂ̃v���C���[�̃X�N���v�g")][SerializeField] Player player;

    [SerializeField] float maxStamina;
    [SerializeField] float stamina;

    // Start is called before the first frame update
    void Start()
    {
        maxStamina = player.GetPlayerData().Stamina;
    }

    // Update is called once per frame
    void Update()
    {
        stamina = player.GetStamina();
        gageImg.fillAmount = stamina / maxStamina;
    }
}
