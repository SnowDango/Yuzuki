using System;
using Oculus.HandManager.viewmodel;
using UnityEngine;
using UnityEngine.UI;

namespace Oculus.HandManager.view
{
    public class InfoText : MonoBehaviour
    {
        [SerializeField, Tooltip("info view")] 
        private TextMesh _text;

        private void Update() {
             _text.text = ViewModel.viewText;
        }
    }
}