using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector_Manipulation;


public class MyVector3_Unity : MonoBehaviour
{
    //Making the target object public to be assigned inside of the editor
    public GameObject target_GameObject;

    MyVector3 self_GameObject_myvector;
    MyVector3 target_GameObject_myvector;

    //Unity Vectors
    Vector3 self_GameObject_unity_vector;
    Vector3 target_GameObject_unity_vector;

    //Vector to Travel To
    Vector3 unity_translation_vector;
    MyVector3 myvector_translation_vector;


    // Start is called before the first frame update
    void Start()
    {
            //Vairable definitions;
                //MyVector3 - Instantiate Objects
        self_GameObject_myvector= new MyVector3(0, 0, 0 );
        target_GameObject_myvector= new MyVector3(0, 0, 0 );

                //Unity Vectors
        self_GameObject_unity_vector= new Vector3(0, 0, 0 );
        target_GameObject_unity_vector= new Vector3(0, 0, 0);

                //Vector to Travel To
        unity_translation_vector= new Vector3(0, 0, 0);
        myvector_translation_vector= new MyVector3(0, 0, 0 );


            //If the target gameobject is not defined, use the slower GameObject.find to assign it.
        if(target_GameObject== null )
        {
            Debug.Log("No game object, assigning manually." );

                //Get player by their name and assign a referance to their GameObject.
            string target_GameObject_name= "Player";
                target_GameObject= GameObject.Find(target_GameObject_name );
        }


        else
        {
            //Debug.Log("No need to assign.");
        }
        

        //Declare Initial Variables.
            //For the chasing GameObject
        self_GameObject_unity_vector= this.transform.position;
        self_GameObject_myvector= self_GameObject_myvector.Unity_Vector3_To_MyVector3(self_GameObject_unity_vector );
            //self_GameObject_myvector= Unity_Vector3_To_MyVector3(self_GameObject_unity_vector );
            //I need to call these functions with an instantiated class

            //For the target GameObject
        target_GameObject_unity_vector = target_GameObject.transform.position;
        target_GameObject_myvector = target_GameObject_myvector.Unity_Vector3_To_MyVector3(target_GameObject_unity_vector);
            //target_GameObject_myvector= Unity_Vector3_To_MyVector3(target_GameObject_unity_vector );

            //Checking the vectors assigned are correct:
                //For the chasing GameObject
            Debug.Log("The chasers starting myvector is: " +self_GameObject_myvector.Output_MyVector3() );
            Debug.Log("The chasers starting vector3 is: " +self_GameObject_unity_vector );   
                Debug.Log("");
                Debug.Log("");
            
             //For the target GameObject
            Debug.Log("The target's myvector is: " +target_GameObject_myvector.Output_MyVector3() );
            Debug.Log("The target's vector3 is: " +target_GameObject_unity_vector );
                Debug.Log("");
                Debug.Log("");

    }


    // Update is called once per frame
    void Update()
    {
            //To ensure it works apply changes to it.
        //target_GameObject.transform.Rotate(100* Time.deltaTime, 0, 0 );

            //Keypress
        if(Input.GetKeyDown("space" ) )
        {
            Debug.Log("----------------------------------------------------------------------------------------------------------------------------------------" );
            Debug.Log("" );

                //Update vectors
                    //Get Unity Vectors
            self_GameObject_unity_vector= this.transform.position;
            target_GameObject_unity_vector= target_GameObject.transform.position;

                //Convert
            self_GameObject_myvector = self_GameObject_myvector.Unity_Vector3_To_MyVector3(self_GameObject_unity_vector );
            target_GameObject_myvector= target_GameObject_myvector.Unity_Vector3_To_MyVector3(target_GameObject_unity_vector );
                    //Checking the vectors assigned are correct:
                Debug.Log("The chaser's vector is " +self_GameObject_myvector.Output_MyVector3() );

                Debug.Log("The target's vector is " +target_GameObject_myvector.Output_MyVector3() );


            //Subtract Vectors to get the "Direction (Target- Base)
            myvector_translation_vector = MyVector3.Subtraction(target_GameObject_myvector, self_GameObject_myvector );
                Debug.Log("The result of the subtraction is: " +myvector_translation_vector.Output_MyVector3() );

            //Apply Transformation to the base GameObject
                //Add translation onto base
            myvector_translation_vector= MyVector3.Addition(self_GameObject_myvector, myvector_translation_vector );
                Debug.Log("The result of the addition is: " + myvector_translation_vector.Output_MyVector3());

            /*myvector_translation_vector = MyVector3.Addition(self_GameObject_myvector, myvector_translation_vector );
                //Convert
            unity_translation_vector= myvector_translation_vector.MyVector3_To_Unity_Vector3();

            Debug.Log("The translation vector is " +unity_translation_vector );

            this.transform.position= this.transform.position + unity_translation_vector;*/

        }
    }
}

