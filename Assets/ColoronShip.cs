using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoronShip : MonoBehaviour {
    public SpriteRenderer rend;
    public Color newcolor;
    bool Blue;
    bool Green;
    bool Randomcolor;
    
	// Use this for initialization
	void Start () {
        Blue = false;
        Green = false;
        Randomcolor = false;
	}
	
	// Update is called once per frame
	void Update () {
        // Ändrar färg till Blå
        if (Input.GetKey(KeyCode.D))
        {
            Blue = true;

            if (Blue == true)
            {
                newcolor = rend.color = new Color(0, 0, 1);

            }

        }
        // Ändrar färg till Grön
        if (Input.GetKey(KeyCode.A))
        {
            Green = true;

            if (Green == true)
            {
                newcolor = rend.color = new Color(0, 1, 0);

            }

        }
        // Random color på alla object
        if (Input.GetKey(KeyCode.Space))
        {
            Randomcolor = true;

            if (Randomcolor == true)
            {
                newcolor = rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

            }

        }
    }
}
