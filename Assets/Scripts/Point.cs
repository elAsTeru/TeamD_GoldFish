using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    //�@�����ʒu
    private Vector3 startPosition;
    //�@�ړI�n
    private Vector3 destination;
    //�@���񂷂�ʒu
    [SerializeField]
    private Transform[] patrolPositions;

    //�@���ɏ��񂷂�ʒu
    private int nowPatrolPosition = 0;

    void OnEnable()
    {
        //�@�����ʒu��ݒ�
        startPosition = transform.position;
        //�@����n�_��ݒ�
        var patrolParent = GameObject.Find("Point");
        patrolPositions = new Transform[patrolParent.transform.childCount];
        for (int i = 0; i < patrolParent.transform.childCount; i++)
        {
            patrolPositions[i] = patrolParent.transform.GetChild(i);
        }
    }

    //�@�����_���Ȉʒu�̍쐬
    public void CreateRandomPosition()
    {
        //�@�����_����Vector2�̒l�𓾂�
        var randDestination = Random.insideUnitCircle * 8;
        //�@���ݒn�Ƀ����_���Ȉʒu�𑫂��ĖړI�n�Ƃ���
        SetDestination(startPosition + new Vector3(randDestination.x, 0, randDestination.y));
    }
    //�@����n�_�����Ɏ���
    public void SetNextPosition()
    {
        SetDestination(patrolPositions[nowPatrolPosition].position);
        nowPatrolPosition++;
        if (nowPatrolPosition >= patrolPositions.Length)
        {
            nowPatrolPosition = 0;
        }
    }
    //�@�ړI�n��ݒ肷��
    public void SetDestination(Vector3 position)
    {
        destination = position;
    }

    //�@�ړI�n���擾����
    public Vector3 GetDestination()
    {
        return destination;
    }
}