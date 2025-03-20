using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    [SerializeField] private Player player;
    
    private const string IS_WALKING = "IsWalking";
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
