using UnityEngine;

public class IKControl : MonoBehaviour
{
    [SerializeField] Transform lookObj;
    Animator animator;
   

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnAnimatorIK()
    {
            animator.SetLookAtWeight(1);
            animator.SetLookAtPosition(lookObj.position);
        
     
    }
   
}