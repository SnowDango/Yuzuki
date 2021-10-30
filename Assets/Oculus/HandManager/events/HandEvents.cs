using UnityEngine;
using UnityEngine.UI;

namespace Oculus.HandManager.events
{
    public class HandEvents
    {
        //debug events TextChange

        private GameObject _GameObject;
        public void debugTextChangeEvent(HandDirection handDirection, HandFace handFace) {
            _GameObject = GameObject.Find("Text");
            var textObject = _GameObject.GetComponent<Text>();
            if (handDirection == HandDirection.Up) {
                textObject.text = "direction: up";
            }else if (handDirection == HandDirection.Left) {
                textObject.text = "direction: left";
            }else if (handDirection == HandDirection.Down) {
                textObject.text = "direction: down";
            }else if (handDirection == HandDirection.Right) {
                textObject.text = "direction: right";
            }else {
                textObject.text = "none";
            }
        }
    }
}