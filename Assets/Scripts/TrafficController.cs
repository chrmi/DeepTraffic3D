using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficController : MonoBehaviour
{
    List<GameObject> cars = new List<GameObject>();

    void PlaceCars()
    {
        int[] lanePositions = { -12, -8, -4, 0, 4, 8, 12 };
        GameObject car = (GameObject)Resources.Load("Car");
        for (int i = -45; i <= 50; i += 20)
        {
            for (int j = 0; j < lanePositions.Length; j++)
            {
                GameObject c = Instantiate(car);
                c.GetComponent<Transform>().position = new Vector3(lanePositions[j], 0, i);
                cars.Add(c);
            }
        }
    }

    void Start()
    {
        PlaceCars();
    }
}
