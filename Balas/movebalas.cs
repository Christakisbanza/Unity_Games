using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebalas : MonoBehaviour{
    public float vel = 2.5f;
    void Start(){
        
    }

    
    void Update(){
        transform.Translate(new Vector2(vel * Time.deltaTime,0));
    }
}
