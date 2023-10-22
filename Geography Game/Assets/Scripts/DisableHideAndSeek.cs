using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableHideAndSeek : MonoBehaviour
{
    [SerializeField] private Image customImage;
    [SerializeField] private Canvas customCanvas;
    void Start()
    {
        customImage.enabled = false;
        customCanvas.enabled = false;
    }
}
