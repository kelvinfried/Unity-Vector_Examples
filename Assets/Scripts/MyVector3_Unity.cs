using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector3_Unity : MonoBehaviour
{
    //Making the target object public to be assigned inside of the editor
    public GameObject target_GameObject;

        // Start is called before the first frame update
    void Start()
    {


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
        
    }

        // Update is called once per frame
    void Update()
    {
            //To ensure it works apply changes to it.
        target_GameObject.transform.Rotate(100* Time.deltaTime, 0, 0 );
    }
}
