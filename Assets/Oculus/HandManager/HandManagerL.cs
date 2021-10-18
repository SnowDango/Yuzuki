using System.Collections;
using UnityEngine;

namespace Oculus.handManager
{
    public class HandManagerL : MonoBehaviour
    {
        [SerializeField, Tooltip("ピンチ状態取得用OVRHand")]
        private OVRHand _ovrHand;
        
        private void Update() {
            // pitch finger list 
            ArrayList fingerPitchList = new ArrayList( 
                capacity: 5
            ) {
                _ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Thumb),
                _ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Index),
                _ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Middle),
                _ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Ring),
                _ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Pinky)
            };

        }
    }
}