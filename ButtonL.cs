using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class ButtonL : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool move;
    public bool PMove;
    // Start is called before the first frame update
    void Start()
    {
        PMove = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            PMove = true;
        }
        else
        {
            PMove = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        move = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        move = false;
    }
}
