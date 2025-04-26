using UnityEngine;
using UnityEngine.UI;

public class magnifyarea : MonoBehaviour
{
    public RectTransform magnifyArea; 
    public float magnifyScale = 1.2f; 
    public float transitionSpeed = 5f; 

    private RectTransform rectTransform; 
    private Vector3 originalScale; 
    public bool isInside = false; 

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
    }

    void Update()
    {
        
        bool currentlyInside = RectTransformUtility.RectangleContainsScreenPoint(magnifyArea, rectTransform.position, null);

        if (currentlyInside && !isInside)
        {
            isInside = true;
        }
        else if (!currentlyInside && isInside)
        {
            isInside = false;
        }

       
        Vector3 targetScale = isInside ? originalScale * magnifyScale : originalScale;
        rectTransform.localScale = Vector3.Lerp(rectTransform.localScale, targetScale, Time.deltaTime * transitionSpeed);
    }
}
