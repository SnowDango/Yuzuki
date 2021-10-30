
using Oculus.HandManager.@enum;
using Oculus.HandManager.events;
using Oculus.HandManager.Info;
using UnityEngine;
using UnityEngine.Serialization;

namespace Oculus.HandManager
{
    public class HandManagerL : MonoBehaviour
    {
        [FormerlySerializedAs("_ovrHand")] [SerializeField, Tooltip("ピンチ状態取得用OVRHand")] 
        private OVRHand ovrHand;

        [FormerlySerializedAs("_ovrSkeleton")] [SerializeField, Tooltip("座標用マーカー")] 
        private OVRSkeleton ovrSkeleton;
        
        //info class
        private FingerInfo _fingerInfo = new FingerInfo();
        private HandInfo _handInfo = new HandInfo();
        private HandEvents _events = new HandEvents();
        
        private void Update() {
            // isTack?
            if (!ovrHand.IsTracked) return;
            // pitch finger list 
            var fingerPitchList = _fingerInfo.getFingerPitchList(ovrHand);
            // finger tip position list
            var fingerBasePositionList = _fingerInfo.getFingerBasePositionList(ovrSkeleton);
            
            //hand direction (enum HandDirection)
            HandDirection handDirection = _handInfo.getHandDirection(fingerBasePositionList);
            //hand face (enum HandFace)
            HandFace handFace = _handInfo.getHandFace(
                HandDomain.Left,
                handDirection,
                _handInfo.getHandHorizontal(fingerBasePositionList)
            );
            _events.debugTextChangeEvent(handDirection,handFace);
        }
    }
}