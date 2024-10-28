using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    private void Update()
    {
        float speed = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(speed));

        Vector2 scale = transform.localScale;

        if (speed < 0)
        {
            scale.x = -1 * Mathf.Abs(scale.x);
        }

        if (speed > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;
    }
}
