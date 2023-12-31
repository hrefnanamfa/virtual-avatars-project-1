using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuickVR.SampleInteraction
{

    public class SampleInteractionStage : QuickStageBase
    {

        #region PROTECTED ATTRIBUTES

        protected Canvas _gui = null;

        #endregion

        #region CREATION AND DESTRUCTION

        protected override void Awake()
        {
            base.Awake();

            _gui = GetComponentInChildren<Canvas>();

            if (_gui)
            {
                _gui.gameObject.SetActive(false);
            }
        }

        public override void Init()
        {
            if (_gui)
            {
                _gui.gameObject.SetActive(true);
            }

            base.Init();
        }

        #endregion

    }

}


