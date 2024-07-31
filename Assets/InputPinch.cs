using TMPro;
using UnityEngine;

public class InputPinch : MonoBehaviour
{
    private Touch touchA;
    private Touch touchB;
    private Vector2 touchDirectionA;
    private Vector2 touchDirectionB;
    private float destTouchesPos;
    private float destTouchesDir;
    [SerializeField] TextMeshProUGUI touchText;
    void Update()
    {
        Pinch();
    }

    private void Pinch()
    {
        if (Input.touchCount == 2)
        {
            touchA = Input.GetTouch(0);
            touchB = Input.GetTouch(1);
            //получаем направление Touch
            touchDirectionA = touchA.position - touchA.deltaPosition;
            touchDirectionB = touchB.position - touchB.deltaPosition;

            //Получаем растояние между двумя Touch
            destTouchesPos = Vector2.Distance(touchA.position, touchB.position);
            destTouchesDir = Vector2.Distance(touchDirectionA, touchDirectionB);
            float pinch = destTouchesDir - destTouchesPos;   
            if (destTouchesDir < destTouchesPos)
            {
               touchText.text = "PINCH +";
            }
            else
            {
               touchText.text = "PINCH -";
            }
        }
    }
}
