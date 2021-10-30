using System.Collections.Generic;
using Oculus.HandManager.@enum;
using UnityEngine;

namespace Oculus.HandManager.Info
{
    public class HandInfo
    {

        // between best direction - 15 to best direction +15
        public HandDirection getHandDirection(Dictionary<FingerList, Vector3> fingerBasePositionList) {
            float directionAngels = getHandDirectionAngels(
                fingerBasePositionList[FingerList.Thumb],
                fingerBasePositionList[FingerList.Middle]
            );
            if (75.0 <= directionAngels && directionAngels <= 105.0) { // best 90
                return HandDirection.Up;
            }else if (165.0 >= directionAngels || directionAngels <= -165.0) { // best 180, -180
                return HandDirection.Left;
            }else if (-75.0 >= directionAngels && directionAngels >= -105.0) { // best -90
                return HandDirection.Down;
            }else if (15.0 >= directionAngels && directionAngels >= -15.0) { // best 0
                return HandDirection.Right;
            }else {
                return HandDirection.None;
            }
        } 
        
        //hand direction(right = 0, up = 90, left = 180(-180), down = -90)
        public float getHandDirectionAngels(Vector3 thumbBase, Vector3 middleBase) {
            Vector3 dt = thumbBase - middleBase;
            float rad = Mathf.Atan2(dt.y, dt.x);
            return (rad * Mathf.Rad2Deg);
        }

        //hand horizontal
        public HandHorizontal getHandHorizontal(Dictionary<FingerList, Vector3> fingerBasePositionList) {
            float horizontalAngels = getHandHorizontalAngels(
                fingerBasePositionList[FingerList.Index],
                fingerBasePositionList[FingerList.Ring]
            );
            if (45.0 <= horizontalAngels && horizontalAngels < 135.0) { // best 90
                return HandHorizontal.Up;
            }else if (135.0 >= horizontalAngels || horizontalAngels < -135.0) { // best 180, -180
                return HandHorizontal.Left;
            }else if (-45.0 > horizontalAngels && horizontalAngels >= -135.0) { // best -90
                return HandHorizontal.Down;
            }else if (45.0 > horizontalAngels && horizontalAngels >= -45.0) { // best 0
                return HandHorizontal.Down;
            }else {
                return HandHorizontal.None;
            }
        }

        //hand Horizontal(Index -> Ring(right = 0, up = 90, left = 180(-180), down = -90))
        public float getHandHorizontalAngels(Vector3 indexBase, Vector3 ringBase) {
            Vector3 dt = indexBase - ringBase;
            float rad = Mathf.Atan2(dt.y, dt.x);
            return (rad * Mathf.Rad2Deg);
        }

        // when HandDirection(Up,Down,Right,Left)
        // HandFace.Face or Back else HandFace.None
        public HandFace getHandFace(HandDomain handDomain,HandDirection handDirection, HandHorizontal handHorizontal) {
            if (handDomain == HandDomain.Left) {
                return getHandFaceL(handDirection, handHorizontal);
            }else if(handDomain == HandDomain.Right){
                return getHandFaceR();
            }else {
                return HandFace.None;
            }
        }
        
        //when HandDomain.Left return HandFace.Face or Back
        private HandFace getHandFaceL(HandDirection handDirection, HandHorizontal handHorizontal) {
            if (handDirection == HandDirection.Up) {
                if (handHorizontal == HandHorizontal.Right) {
                    return HandFace.Face;
                }else if (handHorizontal == HandHorizontal.Left) {
                    return HandFace.Back;
                }else {
                    return HandFace.None;
                }
            }
            return HandFace.Back;
        }

        //when HandDomain.Right return HandFace.Face or Back
        private HandFace getHandFaceR() {
            return HandFace.Face;
        }

    }
}