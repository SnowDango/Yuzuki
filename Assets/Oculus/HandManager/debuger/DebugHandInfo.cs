using System.Collections.Generic;
using UnityEngine;

namespace Oculus.handManager
{
    public class DebugHandInfo
    {

        private void debugHandInfo(
            Dictionary<FingerList, bool> fingerPitchList, 
            Dictionary<FingerList, Vector3> fingerTipPositionList
            ) {
            Debug.Log("pitch info: \n" +
                      $"Thumb = {fingerPitchList[FingerList.Thumb]} \n" +
                      $"Index = {fingerPitchList[FingerList.Index]} \n" +
                      $"Middle = {fingerPitchList[FingerList.Middle]} \n" +
                      $"Ring = {fingerPitchList[FingerList.Ring]} \n" +
                      $"Pinky = {fingerPitchList[FingerList.Pinky]} \n" +
                      $"position info: \n" +
                      $"Thumb Tip = {fingerTipPositionList[FingerList.Thumb]} \n" +
                      $"Index Tip = {fingerTipPositionList[FingerList.Index]} \n" +
                      $"Middle Tip = {fingerTipPositionList[FingerList.Middle]} \n" +
                      $"Ring Tip = {fingerTipPositionList[FingerList.Ring]} \n" +
                      $"Pinky Tip = {fingerTipPositionList[FingerList.Pinky]}");
        }

    }
}