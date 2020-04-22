using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanges : MonoBehaviour
{

    public GameObject lightcolour;
    Color[] colour = new Color[3];
    int index;

    

    //Connect scripts
    private Travel moving;


    public static ColourChanges Instance = null;

    public void Awake()
    {
        Instance = this;

        // storing colours into an array
        colour[0] = Color.red;
        colour[1] = Color.yellow;
        colour[2] = Color.green;
    }



    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(delay());

        /*if (lightcolour.GetComponent<Renderer>().material.color == colour[0])
        {
            StartCoroutine(GreenColour());
        }

        else if (lightcolour.GetComponent<Renderer>().material.color == colour[1])
        {
            StartCoroutine(RedColour());
        }

        else
        {

            StartCoroutine(YellowColour());

        }*/


    }





   



        // get random position within array
        //index = Random.Range(0, colour.Length);


        // set colour to array index position
        //lightcolour.GetComponent<Renderer>().material.color = colour[index];


        /*
         Testing changing colours on start
        int randomcol = Random.Range(1, 4);
        if (randomcol == 1)
        {
            trafficlight.GetComponent<Renderer>().material.color = Color.red;
        }

        else if (randomcol == 2)
        {
            trafficlight.GetComponent<Renderer>().material.color = Color.yellow;
        }

        else
        {
            trafficlight.GetComponent<Renderer>().material.color = Color.green;
        }*/

    

    // Update is called once per frame
    void FixedUpdate()
    {

        /*if (lightcolour.GetComponent<Renderer>().material.color == colour[0])
        {
            StartCoroutine(GreenColour());
        }

        else if (lightcolour.GetComponent<Renderer>().material.color == colour[1])
        {
            StartCoroutine(RedColour());
        }

        else
        {

            StartCoroutine(YellowColour());

        }*/





        /*if (colour[index] == colour[0])
        {
            StartCoroutine(GreenColour());
        }

        else if (colour[index] == colour[1])
        {
            StartCoroutine(RedColour());
        }

        else
        {

            StartCoroutine(YellowColour());

        }*/


    }

    public IEnumerator delay()
    {
        while(true)
        {

        

        if (lightcolour.GetComponent<Renderer>().material.color == colour[0])
        {
            float geenchange = Random.Range(4, 11);
            yield return new WaitForSeconds(geenchange);

                //moving.transform.position = lightcolour.transform.position;

                lightcolour.GetComponent<Renderer>().material.color = colour[1];
        }

        else if (lightcolour.GetComponent<Renderer>().material.color == colour[1])
        {
            float redchange = Random.Range(4, 11);
            yield return new WaitForSeconds(redchange);


            lightcolour.GetComponent<Renderer>().material.color = colour[2];
        }

        else
        {

            yield return new WaitForSeconds(4f);




            lightcolour.GetComponent<Renderer>().material.color = colour[0];

        }

        }

    }

    /*
    //Set delay to change colour
    public IEnumerator GreenColour()
    {
        float geenchange = Random.Range(4, 11);
        yield return new WaitForSeconds(geenchange);

        lightcolour.GetComponent<Renderer>().material.color = colour[1];


    }


    public IEnumerator YellowColour()
    {

        yield return new WaitForSeconds(4f);


        lightcolour.GetComponent<Renderer>().material.color = colour[0];

    }

    public IEnumerator RedColour()
    {
        float redchange = Random.Range(4, 11);
        yield return new WaitForSeconds(redchange);


        lightcolour.GetComponent<Renderer>().material.color = colour[2];

    }
    */

}
