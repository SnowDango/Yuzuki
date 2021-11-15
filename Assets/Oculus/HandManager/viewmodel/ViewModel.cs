using UnityEngine;

namespace Oculus.HandManager.viewmodel
{
    //カメラにつけるViewの状態管理
    public class ViewModel: MonoBehaviour
    {

        public static string viewText = "";

        static string getText() {
            return viewText;
        }

        static void setText(string t) {
            viewText = t;
        }

    }
}