using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

//add this to button
[RequireComponent(typeof(Image))]
public class MyButton : MonoBehaviour , IPointerEnterHandler
{
    public UnityEvent onClick;
    Button testButton;
    
    //set the button when pointer enter the image
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("entering ");
        testButton = ButtonHandler.Instance.SetOverlayAndTakeButtonRef(transform);
        testButton.onClick.RemoveAllListeners();
        testButton.onClick.AddListener(() => onClick.Invoke());
    }

    
}
