using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Lightning Preset", menuName = "Scriptables/Lightning Preset", order = 1)]
public class LightingPreset : ScriptableObject
{
    public Gradient ambientColor;
    public Gradient DirectionalColor;
    public Gradient fogColor;
}
