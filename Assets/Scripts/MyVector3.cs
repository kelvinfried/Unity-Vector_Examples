using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vector_Manipulation
{
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
            //Translation:
                //Vector Addition Function.
        public static MyVector3 Addition(MyVector3 base_vector, MyVector3 offset_vector )
        {
                //Used to store the answers
            float x;
            float y;
            float z; 
        
                //Add each vector's axis value and store it.
            x= base_vector.x+ offset_vector.x;
            y= base_vector.y+ offset_vector.y;
            z= base_vector.z+ offset_vector.z;

                //Initialise a new vector with the values from the addition.
            MyVector3 answer_vector= new MyVector3(x, y, z );

            return answer_vector;
        }


                //Vector Subtraction Function.
        public static MyVector3 Subtraction(MyVector3 base_vector, MyVector3 offset_vector)
        {
                //Used to store the answers
            float x;
            float y;
            float z;

                //Add each vector's axis value and store it.
            x= base_vector.x- offset_vector.x;
            y= base_vector.y- offset_vector.y;
            z= base_vector.z- offset_vector.z;

                //Initialise a new vector with the values from the addition.
            MyVector3 answer_vector = new MyVector3(x, y, z);

            return answer_vector;
        }


            //Scailing:
                //Vector Multiplication
        public static MyVector3 Multiplication(MyVector3 base_vector, float scalar )
        {
                //Used to store the answers
            float x;
            float y;
            float z;

                //Add each vector's axis value and store it.
            x= base_vector.x* scalar;
            y= base_vector.y* scalar;
            z= base_vector.z* scalar;

                //Initialise a new vector with the values from the addition.
            MyVector3 answer_vector = new MyVector3(x, y, z);

            return answer_vector;
        }


                //Vector Division
        public static MyVector3 Division(MyVector3 base_vector, float scalar )
        {                
                //Used to store the answers
            float x;
            float y;
            float z;

                //Add each vector's axis value and store it.
            x= base_vector.x/ scalar;
            y= base_vector.y/ scalar;
            z= base_vector.z/ scalar;

                //Initialise a new vector with the values from the addition.
            MyVector3 answer_vector = new MyVector3(x, y, z);

            return answer_vector;
        }


            //Retuuns the Magnitude of the passed in vector prior to being square rooted.
        public static float Magnitude_Squared_Form(MyVector3 vector )
        {
                  //Stores the answers
            float vector_magnitude= 0.0f;

                //Creates workable copies of the 
            float x_value= vector.x;
            float y_value= vector.y; 
            float z_value= vector.z;

                //Apply pythagoras therom on a 3D Shape
                    //Get the Square of each component to get the squared value of the magnitude.
            vector_magnitude= x_value* x_value + y_value* y_value+ z_value* z_value;

            return vector_magnitude;
        }


            //Vector Magnitude
        public static float Magnitude(MyVector3 vector )
        {
                 //Stores the answers
            float vector_magnitude= 0.0f;

                //Creates workable copies of the 
            float x_value= vector.x;
            float y_value= vector.y; 
            float z_value= vector.z;

                //Apply pythagoras therom on a 3D Shape
                    //Get the Square of each component to get the squared value of the magnitude.
            vector_magnitude= x_value* x_value + y_value* y_value+ z_value* z_value;
            
                    //Square root the value to the magnitude.
            vector_magnitude= Mathf.Sqrt(vector_magnitude );

            return vector_magnitude;
        }


            //Vector Normalised
        public static MyVector3 Normalised(MyVector3 vector )
        {
                //Calculate the magnitude but keep the result in its square form.
            float magnitude_squared_form_value= Magnitude_Squared_Form(vector );

                //Divide the vector by the squared form.
            vector= Division(vector, magnitude_squared_form_value );

                //Square root the result.
            float x= Mathf.Sqrt(vector.x );
            float y= Mathf.Sqrt(vector.y );
            float z= Mathf.Sqrt(vector.z );

            normalised_vector= new MyVector3(x, y, z );

                //Check to see the value (ensure it is near 1 ).
            Output_MyVector3(normalised_vector );

            return normalised_vector;
        }


            //Vector Dot Products
        public static float Dot_Product(MyVector3 base_vector, MyVector3 target_vector )
        {
            float dot_product= 0.0f;
                //Normalise the vectors
            float base_vector_normalised= Normalise(base_vector );
            float target_vector_normalised= Normalise(target_vector );

                //

            return dot_product;
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
        public Vector3 MyVector3_To_Unity_Vector3()
        {
            Vector3 unity_vector;
                //passes the x, y and z values across.
            unity_vector = new Vector3(this.x, this.y, this.z );

            return unity_vector;
        }

            //Overloaded
        public Vector3 MyVector3_To_Unity_Vector3(MyVector3 vector_to_convert )
        {
            Vector3 unity_vector;
                //passes the x, y and z values across.
            unity_vector= new Vector3(vector_to_convert.x, vector_to_convert.y, vector_to_convert.z );

            return unity_vector;
        }


            //Unity's Vector3 to a MyVector3
        public MyVector3 Unity_Vector3_To_MyVector3(Vector3 vector_to_convert )
        {
            MyVector3 myvector3_vector;
                //passes the x, y and z values across
            myvector3_vector= new MyVector3(vector_to_convert.x, vector_to_convert.y, vector_to_convert.z );

            return myvector3_vector;

        }


            // Used to return a string to pass to be outputted to show the vector's value.
        public string Output_MyVector3()
        {
            string output_statement;
            //Use Unity Function to convert floating points to string
                string x_value = this.x.ToString();
                string y_value = this.y.ToString();
                string z_value = this.z.ToString();

            output_statement = "Vector is: " + x_value + ", " + y_value + ", " + z_value;
            return output_statement;
        }

            //Overloaded
        public string Output_MyVector3(MyVector3 vector )
        {
            string output_statement;
                //Use Unity Function to convert floating points to string
                string x_value= vector.x.ToString();
                string y_value= vector.y.ToString();
                string z_value= vector.z.ToString();

            output_statement= "Vector is: " +x_value +", " +y_value +", " +z_value;
                return output_statement;
        }
    }
}
