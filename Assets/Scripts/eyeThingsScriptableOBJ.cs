using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "eyebrowShapeName", menuName = "Eyes/eyebrowShapeName")]
public class EyebrowSetting : ScriptableObject
{
    public eyebrowShape EyebrowShape;
    public Texture EyebrowTexture;
}
[CreateAssetMenu(fileName = "eyeShapeName", menuName = "Eyes/eyeShape")]
public class EyesSetting : ScriptableObject
{
    public eyeShapeType EyeShape;
    public Texture LashTexture;
    public Texture ScleraTexture;
}
[CreateAssetMenu(fileName = "pupilShapeName", menuName = "Eyes/pupilShapeName")]
public class PupilSetting : ScriptableObject
{
    public pupilShape PupilShape;
    public Texture PupilTexture;
}
[CreateAssetMenu(fileName = "irisShapeName", menuName = "Eyes/irisShapeName")]
public class IrisSetting : ScriptableObject
{
    public irisShape IrisShape;
    public Texture IrisTexture;
}
[CreateAssetMenu(fileName = "eyeData", menuName = "Eyes/eyeData")]

public class eyeData : ScriptableObject{
    public List<EyebrowSetting> eyebrowSettingsList;
    public List<EyesSetting> eyeSettingsList;
    public List<PupilSetting> pupilSettingsList;
    public List<IrisSetting> irisSettingsList;
}

