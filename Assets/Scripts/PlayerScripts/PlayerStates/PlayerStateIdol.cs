using UnityEngine;

public partial class Player
{
    /// <summary>
    /// �ҋ@���
    /// 
    /// ���̏�Ԃ���̑J�ڐ��
    /// �ړ����
    /// </summary>
    public class StateIdol : PlayerStateBase
    {
        public override void OnUpdate(Player owner)
        {

            //�ړ���Ԃ̓X�^�~�i���񕜂���
            GameObject StaminaUp = GameObject.Find("PlayerStamina");
            StaminaUp.GetComponent<playerStamina>().StaminaUp(0.1f, owner.GetComponent<Player>().GetPlayerNumber());


            // �ړ���ԂɑJ��
            if (owner.inputValue.x != 0 || owner.inputValue.y != 0)
            {
				owner.ChangeState(move);
            }
        }
    }
}