using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("JumpHeight"), Range(10, 2000)]
    public float JHeight = 100;
    [Header("Dead or alive"), Tooltip("alive or not")]
    public bool life = true;
    private void Jump()
    {

    }
    private void Death()
    {

    }
}
