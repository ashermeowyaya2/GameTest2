using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "eyeShapeName", menuName = "Eyes/eyeShape2")]
public class EyesSetting : ScriptableObject
{
    //public List<EyesSetting> eyeList= new List<EyesSetting>();
    public eyeShapeType EyeShape;
    public Texture LashTexture;
    public Texture ScleraTexture;
}
[CreateAssetMenu(fileName = "eyeData", menuName = "Eyes/eyeData")]
public class eyeData : ScriptableObject{
    public List<EyesSetting> eyeSettingsList;
}

