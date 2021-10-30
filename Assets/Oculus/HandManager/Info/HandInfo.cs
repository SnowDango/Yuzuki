using System.Collections.Generic;
using UnityEngine;

namespace Oculus.handManager
{
    public class HandInfo
    {

        public HandDirection getHandDirection(Dictionary<FingerList, Vector3> fingerBasePositionList) {
            float directionAngels = getHandDirectionAngels(
                fingerBasePositionList[FingerList.Thumb],
                fingerBasePositionList[FingerList.Middle]
            );
            if (75.0 <= directionAngels && directionAngels <= 105.0) {
                return HandDirection.Up;
            }else if (165.0 >= directionAngels || directionAngels <= -165.0) {
                return HandDirection.Left;
            }else if (-75.0 >= directionAngels && directionAngels >= 105.0) {
                return HandDirection.Down;
            }else if (15.0 >= directionAngels && directionAngels >= -15.0) {
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

        //hand Horizontal(Index -> Ring(right = 0, up = 90, left = 180(-180), down = -90))
        public float getHandHorizontalAngels(Vector3 indexBase, Vector3 ringBase) {
            Vector3 dt = indexBase - ringBase;
            float rad = Mathf.Atan2(dt.y, dt.x);
            return (rad * Mathf.Rad2Deg);
        }

        // when HandDirection(Up,Down,Right,Left) return HandFace.Face or Back else HandFace.None
        public HandFace getHandFace(HandDomain handDomain, float handDirection, float handHorizontal) {
            if (handDomain == HandDomain.Left) {
                return getHandFaceL();
            }else if(handDomain == HandDomain.Right){
                return getHandFaceR();
            }else {
                return HandFace.None;
            }
        }
        
        //when HandDomain.Left return HandFace.Face or Back
        private HandFace getHandFaceL() {
            return HandFace.Back;
        }

        //when HandDomain.Right return HandFace.Face or Back
        private HandFace getHandFaceR() {
            return HandFace.Face;
        }

    }
}