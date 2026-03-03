using UnityEngine;
[CreateAssetMenu(fileName = "EyeShapeName", menuName = "Eyes/EyeShapeName")]
public class EyesSetting : ScriptableObject
{
    public eyeShapeType EyeShape;
    public Texture LashTexture;
    public Texture ScleraTexture;
}