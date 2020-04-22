using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleOfObjects : MonoBehaviour
{
    public GameObject trafficlight,point;
    float x;
    float z;

    //store the cyclinder traffic lights positions within an array
    public Vector3[] array = new Vector3[10];


    // Start is called before the first frame update
    void Start()
    {
        this.lightPos();


        // randomly choose point stored and set it to a random light
        int p = Random.Range(0, array.Length);
        point.transform.position = array[p];


    }

    public void lightPos()
    {
        // the position of each light
        Vector3 pos = new Vector3(0, 0, 0);

        //keeping the center points
        Vector3 origin = new Vector3(0, 0, 0);

        

        for (int i = 0; i < 10; i++)
        {

            //Set every traffic light object
            GameObject instance = Instantiate(trafficlight);
           

            // Setting the points on the circle to spawn light
            float radius = i * (2 * Mathf.PI / 10);
            x = Mathf.Sin(radius) * 20f;
            z = Mathf.Cos(radius) * 20f;




            // placing each new point and setting position
            pos = new Vector3(x, 0, z);

            //store all position
            array[i] = pos;

            instance.transform.position = pos;
            //Circle was spawning on top of origin, so this 
            //realigns the traffic lights to look at and ring around
            //the world origin point
            transform.LookAt(origin);
        }




    }
}
