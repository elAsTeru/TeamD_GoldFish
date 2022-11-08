using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePoi : MonoBehaviour
{
    [SerializeField]
    private GameObject createObj;   //��������I�u�W�F�N�g

    [SerializeField]
    private Transform rangeA;   // �����͈́i����j

    [SerializeField]
    private Transform rangeB;   // �����͈́i�E���j

    public float deltaTime;     // �o�ߎ���
    public float createTime;    // �������ԁicreateTime�b��ɐ�������j
    public int nowCreateCount;  // ���݂̐�����
    public int maxCreateCount;  // �ő吶����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���Ԃ����Z
        deltaTime += Time.deltaTime;

        // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȓl���쐬
        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȓl���쐬
        float y = createObj.transform.position.y;
        // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȓl���쐬
        float z = Random.Range(rangeA.position.z, rangeB.position.z);

        // ���������ő�l�𒴂��Ă��Ȃ��Ƃ�
        if(nowCreateCount < maxCreateCount)
        {
            // �O�b���Ƃɐ���
            if (deltaTime > createTime)
            {
                // �I�u�W�F�N�g�𐶐�
                Instantiate(createObj, new Vector3(x, y, z), createObj.transform.rotation);

                // �o�ߎ��Ԃ��O�ɂ��Đ����������Z
                deltaTime = 0.0f;
                nowCreateCount++;
            }
        }
        else
        {
            // �v���I��
            deltaTime = 0.0f;
        }
    }
}
