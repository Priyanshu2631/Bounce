using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb;
    public float s;

    private void Awake(){
        rb=GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate(){
        TouchMove();
    }

    void TouchMove(){
        if(Input.GetMouseButton(0)){
            Vector2 touchPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchPos.x<0){
                rb.velocity=Vector2.left*s;
            }
            else{
                rb.velocity=Vector2.right*s;
            }
        }
        else{
            rb.velocity=Vector2.zero;
        }
    }
}
