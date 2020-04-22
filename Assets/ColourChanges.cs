﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanges : MonoBehaviour
{

    public GameObject lightcolour;
    Color[] colour = new Color[3];
    int index;


    public static ColourChanges Instance = null;

    public void Awake()
    {
        Instance = this;

        colour[0] = Color.red;
        colour[1] = Color.yellow;
        colour[2] = Color.green;
    }



    // Start is called before the first frame update
    void Start()
    {


        // storing colours into an array



       


        // get random position within array
        index = Random.Range(0, colour.Length);


        // set colour to array index position
        lightcolour.GetComponent<Renderer>().material.color = colour[index];




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

    }

    // Update is called once per frame
    void Update()
    {

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

}
