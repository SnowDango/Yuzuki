using System.Collections;
using UnityEngine;

namespace Oculus.handManager
{
    public class HandManagerL : MonoBehaviour
    {
        [SerializeField, Tooltip("ピンチ状態取得用OVRHand")] 
        private OVRHand _ovrHand;

        [SerializeField, Tooltip("座標用マーカー")] 
        private OVRSkeleton _ovrSkeleton;

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

            Debug.Log(_ovrSkeleton.Bones[(int) OVRPlugin.BoneId.Hand_ThumbTip].Transform.position);
        }
    }
}