using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMenu: MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AnimStretch()
    {
        animator.SetBool("Stretch", true);
    }
    public void AnimStretchFalse()
    {
        animator.SetBool("Stretch", false);
    }


}
