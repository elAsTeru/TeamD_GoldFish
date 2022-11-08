using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoiScoop : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //Animator�̎擾
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Player��Collider�͈͓̔��ɓ�������
        if(other.tag == "Player")
        {
            //character_nearby��true�ɂ��Ă�����
            animator.SetBool("ScoopTrigger",true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Player��Collider�͈̔͂���o����
        if (other.tag == "Player")
        {
            //character_nearby��false�ɂ��Ă������̂���߂�
            animator.SetBool("ScoopTrigger", false);
        }
    }

}
