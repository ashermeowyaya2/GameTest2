using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cameraRotation : MonoBehaviour
{
    public GameObject inSceneObj;
    private Vector3 _rotation;
    private Vector3 rotateNine=new Vector3(0,90,0);
    public void rotateObjLeft(){
        inSceneObj.transform.Rotate(_rotation+rotateNine*Time.deltaTime*10f);
    }
    public void rotateObjRight(){
        inSceneObj.transform.Rotate(_rotation-rotateNine*Time.deltaTime*10f);
    }
    public void rotateObjReset(){
        inSceneObj.transform.eulerAngles= Vector3.zero;
    }
}
