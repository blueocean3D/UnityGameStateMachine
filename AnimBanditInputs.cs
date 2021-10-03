using UnityEngine;
using System.Collections;
using AC;

public class AnimBanditInputs : MonoBehaviour
{

    private Animator _animator;
    private AC.Char character;
   

    void Start()
    {
        character = GetComponent<AC.Char>();
        _animator = character.GetAnimator();
    }

    void Update()
    {



        float angle = Mathf.Atan2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Mathf.Rad2Deg;
        _animator.SetFloat("Direction", angle);
        float lean = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Vertical") == 0)
        {
            _animator.SetBool("Idle", true);
            _animator.SetBool("Walk", false);
            _animator.SetBool("Jog", false);
        }
        if (Input.GetAxis("Vertical") > 0.1 && Input.GetAxis("Vertical") < 0.45 )
        {
            _animator.SetBool("Idle", false);
            _animator.SetBool("Walk", true);

        }
        if (Input.GetAxis("Vertical") > 0.45 && Input.GetAxis("Vertical") < 1)
        {
            _animator.SetBool("Idle", false);
            _animator.SetBool("Walk", false);
            _animator.SetBool("Jog", true);
        }
            if (lean > 0.1 || lean < 0.1) {

            _animator.SetFloat("Lean", lean);
            _animator.ResetTrigger("Pivot");
        }
        if (angle > 45    || angle <-45)
        {
            
            _animator.SetTrigger("Pivot");
        }
            
            if (Input.GetKey(KeyCode.Space))
        {
            
            _animator.SetTrigger("Jump");
        }



    }
}
