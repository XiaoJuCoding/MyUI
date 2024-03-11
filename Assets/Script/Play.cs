using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Options;

public class Play : MonoBehaviour
{

    public class PlayDoTweenAnimation : MonoBehaviour
    {

        public RectTransform mRectTransform;
        private bool isOpen = false;

        private Tweener mTweener;
        void Start()
        {
        }

        public void OnClick()
        {
            if (isOpen)
            {
                PlayImage();
                isOpen = false;
            }
            else
            {
                mTweener.PlayBackwards();
                isOpen = true;
            }
        }

        void PlayImage()
        {
            mTweener = mRectTransform.DOLocalMove(new Vector3(-6, -88, 0), 0.3f);
            mTweener.Pause();
            mTweener.SetAutoKill(false);

        }
    }
}
