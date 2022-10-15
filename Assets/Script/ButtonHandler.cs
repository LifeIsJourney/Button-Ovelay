using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//singleton - manages overlay button
public class ButtonHandler : MonoBehaviour
{
    private static ButtonHandler instance;
    public static ButtonHandler Instance { get { return instance; } }

    [SerializeField] GameObject overlayButton;
    Image overlayImg;
    Button imgButton;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public Button SetOverlayAndTakeButtonRef(Transform rect)
    {
        SetOverlayAndButton();
        overlayImg.transform.SetParent(rect);
        overlayImg.transform.SetAsLastSibling();
        overlayImg.rectTransform.anchorMin = Vector2.zero;
        overlayImg.rectTransform.anchorMax = Vector2.one;
        overlayImg.rectTransform.offsetMin = Vector2.zero;
        overlayImg.rectTransform.offsetMax = Vector2.zero;
        return imgButton;
    }

    void SetOverlayAndButton()
    {
        if (overlayImg != null) return;
        GameObject obj = Instantiate(overlayButton, transform);
        obj.SetActive(true);
        overlayImg = obj.GetComponent<Image>();
        imgButton = obj.GetComponent<Button>();
    }
}
