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

}
