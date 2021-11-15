using Oculus.HandManager.viewmodel;
using UnityEngine;
using UnityEngine.UI;

namespace Oculus.HandManager.events
{
    public class HandEvents
    {

        //debug events TextChange
        public void debugTextChangeEvent(HandDirection handDirection, HandFace handFace) { ;
            if (handDirection == HandDirection.Up) {
                ViewModel.viewText = "direction: up";
            }else if (handDirection == HandDirection.Left) {
                ViewModel.viewText = "direction: left";
            }else if (handDirection == HandDirection.Down) {
                ViewModel.viewText = "direction: down";
            }else if (handDirection == HandDirection.Right) {
                ViewModel.viewText = "direction: right";
            }else {
                ViewModel.viewText = "none";
            }
        }

        private Text getTextComponent() {
            return GameObject.Find("DemoObjects").transform
                .Find("Description").transform
                .Find("InfoPanel").transform
                .Find("Background").transform
                .Find("Text").GetComponent<Text>();
        }
    }
}