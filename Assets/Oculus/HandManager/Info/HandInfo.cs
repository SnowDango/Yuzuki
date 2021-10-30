using UnityEngine;

namespace Oculus.handManager
{
    public class HandInfo
    {
        public float getHandAngels(Vector3 thumbBase, Vector3 middleBase) {
            Vector3 dt = thumbBase - middleBase;
            float rad = Mathf.Atan2(dt.y, dt.x);
            return (rad * Mathf.Rad2Deg);
        }
    }
}