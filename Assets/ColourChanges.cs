using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanges : MonoBehaviour
{

    public GameObject lightcolour;
    Color[] colour = new Color[3];


    // Start is called before the first frame update
    void Start()
    {
        

        // storing colours into an array
        colour[0] = Color.red;
        colour[1] = Color.yellow;
        colour[2] = Color.green;

        GameObject change = Instantiate(lightcolour);

        // get random position within array
        int index = Random.Range(0, colour.Length);

        // set colour to array index position
        change.GetComponent<Renderer>().material.color = colour[index];


        if (colour[index] == colour[0])
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

        }

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
        
       

    }

    public IEnumerator GreenColour()
    {
        float geenchange = Random.Range(4, 11);
        yield return new WaitForSeconds(geenchange);
        GameObject greencol = Instantiate(lightcolour);

        greencol.GetComponent<Renderer>().material.color = colour[1];


    }


    public IEnumerator YellowColour()
    {

        yield return new WaitForSeconds(4f);
        GameObject yelcol = Instantiate(lightcolour);


        yelcol.GetComponent<Renderer>().material.color = colour[0];

    }

    public IEnumerator RedColour()
    {
        float redchange = Random.Range(4, 11);
        yield return new WaitForSeconds(redchange);
        GameObject redcol = Instantiate(lightcolour);


        redcol.GetComponent<Renderer>().material.color = colour[2];

    }

}
