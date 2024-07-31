using UnityEngine;
using TMPro;

public class InputTouch : MonoBehaviour
{
    [SerializeField] Touch currentTouch;
    [SerializeField] TextMeshProUGUI touchText;
    private Vector2 swipeStart;
    private Vector2 swipeEnd;
    
    void Update()
    {
        Swipe();
    }
    private void Swipe()
    {
        if (Input.touchCount > 0)
        {
            currentTouch = Input.GetTouch(0);
            if (currentTouch.phase == TouchPhase.Began)
            {
                swipeStart = currentTouch.position;
                touchText.text = string.Empty;
            }
            if (currentTouch.phase == TouchPhase.Ended)
            {
                swipeEnd = currentTouch.position;
            }
            Vector2 resultSwipe = swipeEnd - swipeStart;   
            if (resultSwipe.x >= 100 && resultSwipe.y <=50 && resultSwipe.y >= -50)
            {
                touchText.text = "SWIPE";
            }
        }
    }
}
