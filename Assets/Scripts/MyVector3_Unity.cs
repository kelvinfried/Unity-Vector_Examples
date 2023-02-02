using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector_Manipulation;


public class MyVector3_Unity : MonoBehaviour
{
    //Making the target object public to be assigned inside of the editor
    public GameObject target_GameObject;


        // Start is called before the first frame update
    void Start()
    {
            //Vairable definitions;
                //MyVector3 - Instantiate Objects
        MyVector3 self_GameObject_myvector= new MyVector3(0, 0, 0 );
        MyVector3 target_GameObject_myvector= new MyVector3(0, 0, 0 );

                //Unity Vectors
        Vector3 self_GameObject_unity_vector;
        Vector3 target_GameObject_unity_vector;


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
            Debug.Log("No need to assign.");
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



    }


    // Update is called once per frame
    void Update()
    {
            //To ensure it works apply changes to it.
        target_GameObject.transform.Rotate(100* Time.deltaTime, 0, 0 );


    }
}

