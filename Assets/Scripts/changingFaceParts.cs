using UnityEngine;
using UnityEngine.UI;


////// ENUMS //////
    public enum eyebrowShape{
        defaultEyebrow,
        lineEyebrow,
        smallEyebrow
    }
    public enum eyeShapeType{
        defaultEye,
        catty
    }
    public enum pupilShape{
        defaultPupil,
        star
    }
    public enum irisShape{
        defaultIris
    }

public class changingFaceParts : MonoBehaviour
{

////// VARIABLES //////    
    public Material faceMaterial;
    public eyeData eyeData;
    string ebROffset="_eyeBrowROffset";
    string ebLOffset="_eyeBrowLOffset";
    string eROffset="_eyeROffset";
    string eLOffset="_eyeLOffset";
    string mOffset="_mouthOffset";

    //public int rightEye;
    //public int rightEyeShape;

////// 'TEXTURE FINDERS' //////
    //finds the textures in the (eye)Scriptable Objs and loads them up, basically..
    Texture[] getEyeTextures(eyeShapeType shape){
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
    Texture getPupilTexture(pupilShape shape){
        Texture texture;
        foreach(var setting in eyeData.pupilSettingsList){
            if(setting.PupilShape == shape){
                texture= setting.PupilTexture;
                return texture;
            }
        }
        Texture nuLl=null;
        return nuLl;
    }
////// METHODS //////
    // Some functions, makes it easier for some commands or whatver :thinking moneky:
    void setEyeTexture(eyeShapeType shape){
        faceMaterial.SetTexture("_eyeLash",getEyeTextures(shape)[0]);
        faceMaterial.SetTexture("_eyeSclera",getEyeTextures(shape)[1]);
    }
    void Offset(string x,Vector2 y){
        faceMaterial.SetVector(x,y);
    }

////// EYEBROW AREA //////

    public Slider rightEyeBrowSlider;
    public Slider leftEyeBrowSlider;
    public void changeRightEyebrow(int x){  //changes eyebrow Position,basically
        switch(x){
            default:
            Offset(ebROffset,Vector2.zero);
            break;
            case 1:
            Offset(ebROffset,new Vector2(0.25f,0f));
            break;
            case 2:
            Offset(ebROffset,new Vector2(0.5f,0.75f));
            break;
        }
    }
    public void changeLeftEyebrow(int x){  //changes eyebrow Position,basically
        switch(x){
            default:
            Offset(ebLOffset,Vector2.zero);
            break;
            case 1:
            Offset(ebLOffset,new Vector2(0.25f,0f));
            break;
            case 2:
            Offset(ebLOffset,new Vector2(0.5f,0.75f));
            break;
        }
    }
    public void EyebrowUpdate() // Eyebrow slider thing 
    {
        changeRightEyebrow((int) rightEyeBrowSlider.value);
        changeLeftEyebrow((int) leftEyeBrowSlider.value);
    }

////// OUTSIDE EYE AREA //////

    public void changeEyeShape(int x){  //straighforward enough, i think..
        switch(x){
            case 1:
                setEyeTexture(eyeShapeType.defaultEye);
            break;
            case 2:
                setEyeTexture(eyeShapeType.catty);
            break;
            }
    }

    public Slider rightEyeSlider;
    public Slider leftEyeSlider;
    public void changeRightEye(int x){  //changes eye type, as in, wide, squinting etc.
        switch(x){
            default:
            Offset(eROffset,Vector2.zero);
            break;
            case 1:
            Offset(eROffset,new Vector2(0.25f,0f));
            break;
            case 2:
            Offset(eROffset,Vector2.zero);
            break;
        }
    }

    public void changeLeftEye(int x){  //changes eye type, as in, wide, squinting etc.
        switch(x){
            default:
            Offset(eLOffset,Vector2.zero);
            break;
            case 1:
            Offset(eLOffset,new Vector2(0.25f,0f));
            break;
            case 2:
            Offset(eLOffset,new Vector2(0.5f,0.75f));
            break;
        }
    }
    public void EyeUpdate() // Eye slider thing 
    {
        changeRightEye((int) rightEyeSlider.value);
        changeLeftEye((int) leftEyeSlider.value);
    }

////// INSIDE EYE AREA //////

    public void changePupilShape(int x){
        switch(x){
            case 1:
                faceMaterial.SetTexture("_pupil",getPupilTexture(pupilShape.defaultPupil));
            break;
            case 2:
                faceMaterial.SetTexture("_pupil",getPupilTexture(pupilShape.star));
            break;
            }
    }

    public void irisPos(int x){}

////// MOUTH AREA //////    

    public void changeMouth(int x){  //changes mouth
        switch(x){
            default:
                Offset(mOffset,Vector2.zero);
                break;
            case 1:
                Offset(mOffset,new Vector2(0.25f,0f));
                break;
            case 2:
                Offset(mOffset,new Vector2(0.5f,0f));
                break;
            case 3:
                Offset(mOffset,new Vector2(0.75f,0f));
                break;
            case 4:
                Offset(mOffset,new Vector2(0.0f,-0.25f));
                break;
            case 5:
                Offset(mOffset,new Vector2(0.25f,-0.25f));
                break;
            case 6:
                Offset(mOffset,new Vector2(0.5f,-0.25f));
                break;
            case 7:
                Offset(mOffset,new Vector2(0.75f,-0.25f));
                break;
            case 8:
                Offset(mOffset,new Vector2(0.0f,-0.5f));
                break;
            case 9:
                Offset(mOffset,new Vector2(0.25f,-0.5f));
                break;
            case 10:
                Offset(mOffset,new Vector2(0.5f,-0.5f));
                break;
            case 11:
                Offset(mOffset,new Vector2(0.75f,-0.5f));
                break;
            case 12:
                Offset(mOffset,new Vector2(0.0f,-0.75f));
                break;
            case 13:
                Offset(mOffset,new Vector2(0.25f,-0.75f));
                break;
            case 14:
                Offset(mOffset,new Vector2(0.5f,-0.75f));
                break;
            case 15:
                Offset(mOffset,new Vector2(0.75f,-0.75f));
                break;
        }
    }
}
