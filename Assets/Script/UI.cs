using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public float fadeTime = 1f;
    public CanvasGroup CanvasGroup;
    public RectTransform rectTransform1, rectTransform2, rectTransform3,rectTransform4;
    public bool isOpen = true;
    public float mx,my;
    public Joystick joystick;

    private void FixedUpdate()
    {
        mx = joystick.Horizontal;
        my = joystick.Vertical;
        Debug.Log($"{mx},{my}");
    }


    public void PanelFadeIn()
    {
        CanvasGroup.alpha = 0f;
        rectTransform1.transform.localPosition = new Vector3(0f, 0f, 0f);
        rectTransform1.DOAnchorPos(new Vector2(-194f, -51f), fadeTime, false)/*.SetEase(Ease.OutElastic)*/;
        rectTransform2.transform.localPosition = new Vector3(0f, 0f, 0f);
        rectTransform2.DOAnchorPos(new Vector2(-189f, 91f), fadeTime, false)/*.SetEase(Ease.OutElastic)*/;
        rectTransform3.transform.localPosition = new Vector3(0f, 0f, 0f);
        rectTransform3.DOAnchorPos(new Vector2(-77f, 199f), fadeTime, false)/*.SetEase(Ease.OutElastic)*/;
        rectTransform4.transform.localPosition = new Vector3(0f, 0f, 0f);
        rectTransform4.DOAnchorPos(new Vector2(74f, 244f), fadeTime, false)/*.SetEase(Ease.OutElastic)*/;
        CanvasGroup.DOFade(1,fadeTime);
    }
    public void PanelFadeOut()
    {
        CanvasGroup.alpha = 1f;
        rectTransform1.transform.localPosition = new Vector3(-194f, -51f, 0f);
        rectTransform1.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false)/*.SetEase(Ease.InOutElastic)*/;
        rectTransform2.transform.localPosition = new Vector3(-189f, 91f, 0f);
        rectTransform2.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false)/*.SetEase(Ease.InOutElastic)*/;
        rectTransform3.transform.localPosition = new Vector3(-77f, 199f, 0f);
        rectTransform3.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false)/*.SetEase(Ease.InOutElastic)*/;
        rectTransform4.transform.localPosition = new Vector3(74f, 244f, 0f);
        rectTransform4.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false)/*.SetEase(Ease.InOutElastic)*/;
        CanvasGroup.DOFade(0, fadeTime);
    }

    public void Switch()
    {
        if (isOpen)
        {
            PanelFadeOut();
            isOpen = false;
        }
        else
        {
            PanelFadeIn();
            isOpen = true;
        }
    }

}
