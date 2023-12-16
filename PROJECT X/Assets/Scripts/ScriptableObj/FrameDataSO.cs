using UnityEngine;

[CreateAssetMenu(fileName = "FrameData", menuName = "ScriptableObjects/FrameData")]
public class FrameDataSO : ScriptableObject
{
    [Header("Info")]
    [SerializeField] private new string name;
    [Header("FrameData/Timing")]
    [SerializeField] private float startupTime;
    [SerializeField] private float activeTime;
    [SerializeField] private float recoveryTime;

    public float GetTime(int frame)
    {
        switch (frame)
        {
            case 0:
                return startupTime;
            case 1:
                return recoveryTime;
            case 2:
                return activeTime;
            default:
                return -1;

        }
    }

    public float GetTotalTime() { 
        return startupTime + activeTime + recoveryTime;
    }
}
