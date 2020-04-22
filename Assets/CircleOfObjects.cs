using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleOfObjects : MonoBehaviour
{
    public GameObject trafficlight,point;

    Color[] colour = new Color[3];
    int index;

    int loc = 0;

    bool check = false;


    public Color[] store_col = new Color[10];


    //store the cyclinder traffic lights positions within an array
    public Vector3[] array = new Vector3[10];


    // Start is called before the first frame update
    void Start()
    {
        this.lightPos();

        // seeing that now both a colour is linked with a location this loop
        //will hopefully cycle through the ring and set the travel point to the first
        // green light it lands on
        // getting an infinate loop error
        /*while (check == false)
        {
            if(store_col[loc] == Color.green)
            {
                point.transform.position = array[loc];

                check = false;
            }

            else
            {
                loc++;
            }

        } */

        
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

        colour[0] = Color.red;
        colour[1] = Color.yellow;
        colour[2] = Color.green;



        for (int i = 0; i < 10; i++)
        {

            //Set every traffic light object
            GameObject instance = Instantiate(trafficlight);
           

            // Setting the points on the circle to spawn light
            float radius = i * (2 * Mathf.PI / 10);
            float x = Mathf.Sin(radius) * 20f;
            float z = Mathf.Cos(radius) * 20f;

            index = Random.Range(0, colour.Length);


            // set colour to array index position
            instance.GetComponent<Renderer>().material.color = colour[index];

            store_col[i] = colour[index];




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
