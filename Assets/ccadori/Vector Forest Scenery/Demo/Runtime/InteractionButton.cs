using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorForestScenery.Demo
{
    public class InteractionButton : MonoBehaviour
    {
        [SerializeField] AudioSource buttonClick;
        #region "Inspector"
        public Demo _demo;
        public InteractionType _interactionType;
        #endregion

        public virtual void OnClick()
        {
            _demo.CurrentInteraction = _interactionType;
            buttonClick.Play();
        }
    }
}
