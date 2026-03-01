using System.Collections.Generic;
using UnityEngine;

public enum irisShape{
    defaultIris=1,
    star
}
public enum eyeShape{
    defaultEye,
    bunny
}
public class changingFaceParts : MonoBehaviour
{

        public List<EyesSetting> test2= new List<EyesSetting>();


    public irisShape IrisShape;

    public void Change(irisShape change){
        //Debug.Log("default");
        switch ((int) change){
            case 1:
                Debug.Log("default");
            break;
            case 2:
                Debug.Log("star");
            break;

            default:
                Debug.Log("default");
            break;
        }
    }
    void Update(){
        Change(IrisShape);
        //public List<Sprite> test2= new List<Sprite>();
    }
}

[CreateAssetMenu(fileName = "EyesSetting", menuName = "Scriptable Objects/EyesSetting")]

public class EyesSetting: ScriptableObject{
    eyeShape EyeShape;
    Sprite LashTexture;
    Sprite ScleraTexture;

}