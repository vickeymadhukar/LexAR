using UnityEngine;
using UnityEngine.EventSystems;

public class TouchRotation : MonoBehaviour
{
    public float rotationSpeed = 0.2f; 
    public RectTransform touchArea;
    private Vector2 lastTouchPosition; 
    private bool isTouching = false; 
    private Vector3 currentRotation; 

    void Start()
    {
       
        currentRotation = transform.eulerAngles;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

           
            if (RectTransformUtility.RectangleContainsScreenPoint(touchArea, touch.position, null))
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        
                        lastTouchPosition = touch.position;
                        isTouching = true;
                        break;

                    case TouchPhase.Moved:
                        if (isTouching)
                        {
                            
                            Vector2 touchDelta = touch.position - lastTouchPosition;

                          
                            float rotationX = touchDelta.y * rotationSpeed;
                            float rotationY = -touchDelta.x * rotationSpeed;

                            transform.Rotate(Vector3.up, rotationY, Space.World);   
                            transform.Rotate(Vector3.right, rotationX, Space.World);

                           
                            lastTouchPosition = touch.position;
                        }
                        break;

                    case TouchPhase.Ended:
                    case TouchPhase.Canceled:
                       
                        isTouching = false;
                        break;
                }
            }
            else
            {
              
                isTouching = false;
            }
        }
    }
}
