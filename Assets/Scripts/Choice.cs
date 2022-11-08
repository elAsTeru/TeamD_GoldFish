using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Choice : MonoBehaviour
{

    //�@�ŏ��Ƀt�H�[�J�X����Q�[���I�u�W�F�N�g
    [SerializeField]
    private GameObject firstSelect;

    public GameObject button;
    public GameObject button2;

    private EventSystem mES;

    void Start()
    {
        mES = GetComponent<EventSystem>();
        //�{�^�����I�����ꂽ��ԂɂȂ�
        //button.Select();
        EventSystem.current.SetSelectedGameObject(button);
    }

    private void Update()
    {
        // �Q�[���p�b�h�̃X�e�B�b�N�̌X�������̒l���擾
        float y = Input.GetAxis("Vertical1");

        // �X����1�̎��i���ɓ|���Ă���Ƃ��j
        if (/*Input.GetKeyDown(KeyCode.UpArrow)*/ y >= 1)
        {
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(button);
        }
        // �X����-1�̎��i���ɓ|���Ă���Ƃ��j
        if (/*Input.GetKeyDown(KeyCode.DownArrow)*/ y <= -1)
        {
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(button2);
        }
    }
}
