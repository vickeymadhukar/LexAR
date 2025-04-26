using UnityEngine;
using UnityEngine.EventSystems;

public class axisRotation : MonoBehaviour
{
    public RectTransform touchArea;       
    public float rotationSpeed = 0.2f;    

    public bool rotateX = true;           
    public bool rotateY = true;           
    public bool rotateZ = false;        

    private Vector2 lastTouchPosition;
    private bool isTouching = false;

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
                            Vector2 delta = touch.position - lastTouchPosition;

                            if (rotateY)
                                transform.Rotate(Vector3.up, -delta.x * rotationSpeed, Space.World);

                            if (rotateX)
                                transform.Rotate(Vector3.right, delta.y * rotationSpeed, Space.World);

                            if (rotateZ)
                                transform.Rotate(Vector3.forward, -delta.x * rotationSpeed, Space.World);

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
