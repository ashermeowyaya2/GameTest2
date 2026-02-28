using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cameraRotation : MonoBehaviour
{
    public GameObject inSceneObj;
    
    public float y;
    public float yNew;

    public void Update(){
        y= inSceneObj.transform.localEulerAngles.y;
        yNew= inSceneObj.transform.rotation.eulerAngles.y;
    }

    public void rotateObj(int x){
        switch(x){
            case 1:
                yNew= y -90f ;//Quaternion.Euler(y-(new Vector3(0f, 90f, 0f)));
                break;
            case 2:
                yNew= y +90f ;//Quaternion.Euler(y+(new Vector3(0f, 90f, 0f)));
                break;
        }
    }
}
