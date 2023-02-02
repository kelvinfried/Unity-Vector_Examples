using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Inheritance from Monobehaviour class removed.
public class MyVector3
{
        //3D Vectors parameters
    public float x;
    public float y;
    public float z;

        //Constructor
    public MyVector3(float init_x, float init_y, float init_z )
    {
        this.x= init_x;
        this.y= init_y;
        this.z= init_z;
    }


    //Functions
        //Static Functions:
        //Vector Addition Function.
    public static MyVector3 Addition(MyVector3 starting_vector, MyVector3 offset_vector )
    {
            //Used to store the answers
        float x;
        float y;
        float z; 
        
            //Add each vector's axis value and store it.
        x= starting_vector.x+ offset_vector.x;
        y= starting_vector.y+ offset_vector.y;
        z= starting_vector.z+ offset_vector.z;

            //Initialise a new vector with the values from the addition.
        MyVector3 answer_vector= new MyVector3(x, y, z );

        return answer_vector;
    }


        //Vector Subtraction Function.
    public static MyVector3 Subtraction(MyVector3 starting_vector, MyVector3 offset_vector)
    {
            //Used to store the answers
        float x;
        float y;
        float z;

            //Add each vector's axis value and store it.
        x = starting_vector.x - offset_vector.x;
        y = starting_vector.y - offset_vector.y;
        z = starting_vector.z - offset_vector.z;

            //Initialise a new vector with the values from the addition.
        MyVector3 answer_vector = new MyVector3(x, y, z);

        return answer_vector;
    }


        //Functions
        //Vector Magnitude.
    public float Magnitude()
    {
            //Stores the answers
        float vector_magnitude= 0.0f;

            //Creates workable copies of the 
        float x_value= this.x;
        float y_value= this.y; 
        float z_value= this.z;

            //Apply pythagoras therom on a 3D Shape
                //Get the Square of each component to get the squared value of the magnitude.
        vector_magnitude= x_value* x_value + y_value* y_value+ z_value* z_value;
            
                //Square root the value to the magnitude.
        vector_magnitude= Mathf.Sqrt(vector_magnitude );

        return vector_magnitude;
    }

        //MyVector3 to a Unity's Vector3
    public Vector3 MyVector3_To_Unity_Vector(MyVector3 vector_to_convert )
    {
        Vector3 unity_vector;
            //passes the x, y and z values across via the constructor (overloaded).
        unity_vector= new Vector3(vector_to_convert.x, vector_to_convert.y, vector_to_convert.z );

        return unity_vector;
    }

}
