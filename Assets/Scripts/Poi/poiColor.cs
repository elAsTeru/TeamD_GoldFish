using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poiColor : MonoBehaviour
{
    public GameObject mPoi;
    public Material m1PColor;
    public Material m2PColor;

    /// <summary>
    /// �|�C�̐F��ύX
    /// </summary>
    /// <param name="_target">�ǂ��Ώ�</param>
    /// <param name="_1PObj">1P</param>
    /// <param name="_2PObj">2P</param>
    public void ColorUpdate(Transform _target, GameObject _1PObj, GameObject _2PObj)
    {
        // target��1P�ł�������
        if(_target == _1PObj.transform)
        {
            mPoi.gameObject.GetComponent<Renderer>().material.color = m1PColor.color;
        }
        // target��2P�ł�������
        if (_target == _2PObj.transform)
        {
            mPoi.gameObject.GetComponent<Renderer>().material.color = m2PColor.color;
        }
    }
}
