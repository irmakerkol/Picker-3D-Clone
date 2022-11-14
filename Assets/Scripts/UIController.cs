using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : Singleton<UIController>
{
    public Canvas startCanvas;
    public Canvas endCanvas;
    public Canvas inGameCanvas;

    public void StartCanvasOn()
    {
        startCanvas.gameObject.SetActive(true);
        endCanvas.gameObject.SetActive(false);
        inGameCanvas.gameObject.SetActive(false);
    }

    public void InGameCanvasOn()
    {
        startCanvas.gameObject.SetActive(false);
    }

    public void EndCanvasOn()
    {
        inGameCanvas.gameObject.SetActive(false);
        endCanvas.gameObject.SetActive(true);
    }
}
