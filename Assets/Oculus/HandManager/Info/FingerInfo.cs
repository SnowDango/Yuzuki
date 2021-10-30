using System;
using System.Collections.Generic;
using UnityEngine;

namespace Oculus.handManager
{
    public class FingerInfo
    {
        public Dictionary<FingerList, bool> getFingerPitchList(OVRHand ovrHand) {
            return new Dictionary<FingerList, bool>( 
                capacity: 5
            ) {
                {FingerList.Thumb, ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Thumb)},
                {FingerList.Index, ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Index)},
                {FingerList.Middle, ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Middle)},
                {FingerList.Ring, ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Ring)},
                {FingerList.Pinky, ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Pinky)}
            };
        }

        public Dictionary<FingerList, Vector3> getFingerBasePositionList(OVRSkeleton ovrSkeleton) {
            return new Dictionary<FingerList, Vector3>(
                capacity: 5
            ) {
                {FingerList.Thumb, ovrSkeleton.Bones[(int) OVRPlugin.BoneId.Hand_Thumb0].Transform.position},
                {FingerList.Index, ovrSkeleton.Bones[(int) OVRPlugin.BoneId.Hand_Index1].Transform.position},
                {FingerList.Middle, ovrSkeleton.Bones[(int) OVRPlugin.BoneId.Hand_Middle1].Transform.position},
                {FingerList.Ring, ovrSkeleton.Bones[(int) OVRPlugin.BoneId.Hand_Ring1].Transform.position},
                {FingerList.Pinky, ovrSkeleton.Bones[(int) OVRPlugin.BoneId.Hand_Pinky1].Transform.position}
            };
        }
    }
}