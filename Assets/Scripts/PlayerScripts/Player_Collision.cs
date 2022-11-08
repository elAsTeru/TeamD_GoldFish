using UnityEngine;

public partial class Player
{
    [Header("�����蔻��")]
    [Tooltip("�_�b�V���U�������蔻�肪�������I�u�W�F�N�g")][SerializeField] GameObject dashCollObj;
    [Tooltip("��]�U�������蔻�肪�������I�u�W�F�N�g")][SerializeField] GameObject spinCollObj;

    private void OnCollisionEnter(Collision collision)
    {
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != this.gameObject && other.tag == this.tag)
        if(state == dash)
        {
                mgr.AttackProc(this.gameObject, other.gameObject, PlayerMgr.AtkState.Dash);
        }
        else if(state == spin)
        {
                mgr.AttackProc(this.gameObject, other.gameObject, PlayerMgr.AtkState.Spin);
        }

        state = idol;
    }
}