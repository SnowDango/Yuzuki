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
            
            //hand direction (enum HandFace)
            HandDirection handDirection = _handInfo.getHandDirection(fingerBasePositionList);
            
            
            
            //hand face(enum HandFace)

        }
    }
}