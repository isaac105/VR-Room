using UnityEngine;

public class OnSelectBookUseMotor : MonoBehaviour
{
    private HingeJoint coverHinge;

    void Awake()
    {
        coverHinge = GetComponentInChildren<HingeJoint>(true);
    }

    public void SetUseMotor()
    {
        if (coverHinge != null)
        {
            coverHinge.useMotor = true;
        }
    }
}