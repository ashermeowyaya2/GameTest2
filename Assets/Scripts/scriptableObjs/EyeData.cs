using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "EyeData", menuName = "Eyes/EyeData", order = 1)]

public class EyeData : ScriptableObject{
    public List<EyebrowSetting> eyebrowSettingsList;
    public List<EyesSetting> eyeSettingsList;
    public List<PupilSetting> pupilSettingsList;
    public List<IrisSetting> irisSettingsList;
}

