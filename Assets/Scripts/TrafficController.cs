using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class TrafficController : MonoBehaviour {
    #if UNITY_WEBGL
   [DllImport("__Internal")]
    private static extern void FinishLoading();
    #endif

    void PlaceCars()
    {
        for (int i = 0; i < 7; i++)
        {
            if (i == 3)
                continue;
            GameObject car = Instantiate((GameObject)Resources.Load("Car"));
            Vector3 carPos = car.GetComponent<Transform>().position;
            car.GetComponent<Transform>().position = new Vector3((i * 4) - 12, carPos.y, Random.Range(-30f, 30f));
            Object.Destroy(car, 400f);
        }
    }
    void Start()
    {
        #if UNITY_WEBGL
        FinishLoading();
        #endif
        PlaceCars();
    }
}
