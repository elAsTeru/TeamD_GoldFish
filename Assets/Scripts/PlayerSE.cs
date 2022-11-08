using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSE : MonoBehaviour
{
    //SE�֘A
    public AudioClip SelectSound; //�Z���N�g�T�E���h
    public AudioClip HitSound; //�U���q�b�g�T�E���h
    public AudioClip DashSound; //�_�b�V���T�E���h
    public AudioClip JumpSound; //�W�����v�T�E���h
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //-----------------------------
        //�Z���N�g�����ɒǉ�
        //-----------------------------
        //�Z���N�g�T�E���h���Đ�����
        audioSource.clip = SelectSound;
        audioSource.Play();


        //-----------------------------
        //�U�������ɒǉ�
        //-----------------------------
        //�U���q�b�g�T�E���h���Đ�����
        audioSource.clip = HitSound;
        audioSource.Play();

        //-----------------------------
        //�_�b�V�������ɒǉ�
        //-----------------------------
        //�_�b�V���T�E���h���Đ�����
        audioSource.clip = DashSound;
        audioSource.Play();


        //-----------------------------
        //�W�����v�����ɒǉ�
        //-----------------------------
        //�W�����v�T�E���h���Đ�����
        audioSource.clip = JumpSound;
        audioSource.Play();

    }
}
