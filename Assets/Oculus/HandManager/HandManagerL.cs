using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Oculus.handManager
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
        

        private void Update() {
            // isTack?
            if (!ovrHand.IsTracked) return;
            // pitch finger list 
            var fingerPitchList = _fingerInfo.getFingerPitchList(ovrHand);
            // finger tip position list
            var fingerBasePositionList = _fingerInfo.getFingerBasePositionList(ovrSkeleton);
            
            //hand direction(right = 0, up = 90, left = 180(-180), down = -90)
            float handDirection = _handInfo.getHandAngels(
                fingerBasePositionList[FingerList.Thumb],
                fingerBasePositionList[FingerList.Middle]
            );
            

        }
        
    }
}