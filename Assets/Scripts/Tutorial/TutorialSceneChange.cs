using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSceneChange : MonoBehaviour
{
    public FadeScene mFadeScene;
    public Fade mFade;

    // Start is called before the first frame update
    void Start()
    {
        mFadeScene.FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        // �{�^�����͂ŃV�[���J��
        if(Input.GetButtonDown("Submit"))
        {
            mFadeScene.Fadeout();
        }
    }
}
