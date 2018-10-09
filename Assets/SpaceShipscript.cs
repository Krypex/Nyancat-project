using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipscript : MonoBehaviour {
    [Range(-720, 720)]
    public float rotationSpeed;
    public bool halfspeed;
   public Transform other;
    public float Timer;
    private float variabel = 1;
    public float newPostions;
    public float randomspeed;
    public float newPostionss;
    // Use this for initialization
    void Start()
    {
        halfspeed = false; // Gör halfspeed of 
        randomspeed = Random.Range(5, 10); // randomiserar hastigheten i början fårn 1 till 10

        transform.position = new Vector3(Random.Range(-9, 9), Random.Range(-5, 5));
    }  
    // Update is called once per frame
	void Update ()
        {
        transform.Translate(randomspeed * Time.deltaTime, 0, 0, Space.Self); // Objektet åker fram och Gör hastigheten för skepet oberoende av FPS

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime); // Svänger höger och gör det oberonde av FPS

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);  // Svänger Vänster och gör det oberoende av FPS

        }
        if (Input.GetKey(KeyCode.S))
        {

                transform.Translate(randomspeed/ -2 * Time.deltaTime, 0, 0, Space.Self); // När man Trycker ner S så åker den dubelts så långsammt
        }
        //if (Input.GetKeyUp(KeyCode.S))
        {
           // transform.Translate(randomspeed * 2 * Time.deltaTime, 0, 0, Space.Self);
        }
        Timer += Time.deltaTime; // Timer ökar varenda sekund i real tid
        if (Timer > variabel && Timer < variabel + 0.2)
        {
            Debug.Log(string.Format("Timer:"));

            print(Timer);
            variabel = (variabel + 1);
            
        } 
        Vector3 newPosition = transform.position; // skapar position
        if (newPosition.x > 8.89f || newPosition.x < -8.89f)
        {
            newPosition.x = -newPosition.x; // sätter ny position x

        }
        if (newPosition.y > 5.0f || newPosition.y < -5.0f)
        {
            newPosition.y = -newPosition.y; // sätter ny position y

        }
        transform.position = newPosition; // sätter skeppets position

    }
}
