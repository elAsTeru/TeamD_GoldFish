using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ResultPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject firstSelect;     //�@�ŏ��Ƀt�H�[�J�X����Q�[���I�u�W�F�N�g

    public GameObject button;   // �{�^��

    private EventSystem mES;    // EventSystem���擾

    [SerializeField]
    Text buttonText;        // �{�^����Text

    [Header("1���[�v�̒���(�b�P��)")]
    [SerializeField]
    [Range(0.1f, 10.0f)]
    float duration = 1.0f;

    [Header("���[�v�J�n���̐F")]
    [SerializeField]
    Color32 startColor = new Color32(255, 255, 255, 255);

    [Header("���[�v�I�����̐F")]
    [SerializeField]
    Color32 endColor = new Color32(255, 255, 255, 64);


    // Start is called before the first frame update
    void Start()
    {
        // Text�R���|�[�l���g�������Ă��Ȃ��Ƃ�
        if (buttonText == null)
        {
            buttonText = GetComponent<Text>();
        }

        mES = GetComponent<EventSystem>();
        //�{�^�����I�����ꂽ��ԂɂȂ�
        //button.Select();
        EventSystem.current.SetSelectedGameObject(button);
    }

    // Update is called once per frame
    void Update()
    {
        // �{�^���e�L�X�g�̐F��_�ł�����
        buttonText.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time / duration, 1.0f));

        //EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(button);
    }
}
