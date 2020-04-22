using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public GameObject car;
    public GameObject trafficlights;

    public void Start()
    {
        this.TravelRing();

    }


    public void TravelRing()
    {
        Vector3 pos = Vector3.zero;

        for(int i = 0; i < 10; i++)
        {
            float angle = i * (2 * 3.14159f / 10);

            float x = Mathf.Cos(angle) * 1.5f;
            float y = Mathf.Sin(angle) * 1.5f;

            pos = new Vector3(pos.x + x, pos.y + y, 0);

            trafficlights.transform.position = pos;

        }
        
    }
}
