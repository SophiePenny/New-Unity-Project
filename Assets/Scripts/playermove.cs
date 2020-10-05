using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    
    // Start is called before the first frame update


    public int lives = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed;
        float ySpeed;

        if (Input.GetKey("left"))
        {
         xSpeed = -1.0f;

         transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
         
       
        }

        if (Input.GetKey("right"))
        {
         ySpeed = 1.0f;

         transform.position += new Vector3(ySpeed * Time.deltaTime, 0, 0);


        }

        if (Input.GetKey("up"))
        {
         ySpeed = 1.0f;

         transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);


        }

        if (Input.GetKey("down"))
        {
         ySpeed = -1.0f;

         transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);


        }

        if (Input.GetKey("x"))
        {
            lives = 0;

          


        }



    }
}
