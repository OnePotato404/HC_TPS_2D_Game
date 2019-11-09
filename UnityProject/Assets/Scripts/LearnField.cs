using UnityEngine;

public class LearnField : MonoBehaviour
{
    [Header("角色等級"), Range(1, 9999)]
    public int lv = 1;
    [Tooltip("角色移動速度>>>別調太高")]
    [Range(0.1f,99.9f)]
    public float speed = 1.5F;
    public string propl = "藥水";
    public bool mission = true;
}
