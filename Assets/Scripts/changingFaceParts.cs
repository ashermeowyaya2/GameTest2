using UnityEngine;

public enum irisShape{
    defaultIris=1,
    star
}

public enum eyeShapeType{
    defaultEye,
    catty
}

public class changingFaceParts : MonoBehaviour
{
    public eyeData eyeData;
    public Texture[] getEyeTextures(eyeShapeType shape){
        Texture[] textures= new Texture[2];
        foreach(var setting in eyeData.eyeSettingsList){
            if(setting.EyeShape == shape){
                textures[0]= setting.LashTexture;
                textures[1]= setting.ScleraTexture;
                return textures;
            }
        }
        return new Texture[2]{null,null};
    }
    public int rightEyeShape;
    void setEyeTexture(eyeShapeType shape){
        faceMaterial.SetTexture("_eyeLash",getEyeTextures(shape)[0]);
        faceMaterial.SetTexture("_eyeSclera",getEyeTextures(shape)[1]);
    }
    public void changeRightEyeShape(int x){
        switch(x){
            case 1:
                setEyeTexture(eyeShapeType.defaultEye);
            break;
            case 2:
                setEyeTexture(eyeShapeType.catty);
            break;
            }
    }

    string eROffset="_eyeROffset";
    
    public int rightEye;
    public Material faceMaterial;
    void Offset(string x,Vector2 y){
        faceMaterial.SetVector(x,y);
    }
    public void changeRightEye(int x){
        switch(x){
            case 1:
            Offset(eROffset,new Vector2(0.25f,0f));
            break;
            case 2:
            Offset(eROffset,new Vector2(0.5f,0.75f));
            break;
        }
    }
    void Update(){
        changeRightEye(rightEye);
        changeRightEyeShape(rightEyeShape);
    }
}

