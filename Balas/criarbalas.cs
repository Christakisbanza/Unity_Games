using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class criarbalas : MonoBehaviour{
    
    public GameObject balas;
    public GameObject cano;
    void Start(){
        
    }

    
    void Update(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Instantiate(balas,new Vector3(cano.transform.position.x,cano.transform.position.y,cano.transform.position.z), cano.transform.rotation);
        }
    }
}
