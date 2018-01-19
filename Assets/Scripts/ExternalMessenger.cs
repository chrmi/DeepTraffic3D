using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class ExternalMessenger : MonoBehaviour {
    #if UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern void FinishLoading();
    #endif

    void Start()
    {
        #if UNITY_WEBGL
        FinishLoading();
        #endif
    }
}
