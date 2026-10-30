using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            rb.position += new Vector2(1f,0f);  
        }
        else if(Keyboard.current.aKey.wasPressedThisFrame)
        {
            rb.position += new Vector2(-1f, 0f);
        }
        else if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {

        }
        else if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {

        }
        else if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            rb.gravityScale = -1f;
        }
        else if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            rb.gravityScale = 1f;
        }
    }
}
