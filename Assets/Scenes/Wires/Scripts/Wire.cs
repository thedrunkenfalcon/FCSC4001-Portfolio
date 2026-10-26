using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class Wire : MonoBehaviour//, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    [SerializeField]
    public LineRenderer line;
    [SerializeField]
    public Transform endWire;
    [SerializeField]
    bool right = false;
    [SerializeField]
    SpriteRenderer vis;


    [SerializeField]
    public ScoreLogic scoreLogic;
    
    bool dragging = false;
    bool connected = false;
    Vector3 startPos;
    Vector3 endWireDif;
    
    private float tip = 0.5f;
    private float end = 0.15f;
    private float Dmod = 1f;

    SpriteRenderer sprite;



    void Start()
    {
        //mouseMov = InputSystem.actions.FindAction("Look");
        startPos = transform.position;
        sprite = GetComponent<SpriteRenderer>();
        if (right)
        {
            tip = -0.5f;
            end = -0.15f;
            //start2 = -0.25f;
        }
        if (test.mode == 'M')
        {
            Dmod = 1.5f;
        }
        else if (test.mode == 'H')
        {
            Dmod = 2f;
        }
        else
        {
            Dmod = 1f;
        }
    }


    void Update()
    {
        if (dragging)
        {
            Vector3 mouseposition = Input.mousePosition;
            Vector3 convertedMousePosition = Camera.main.ScreenToWorldPoint(mouseposition);
            convertedMousePosition.z = -0.05f;
            SetPosition(convertedMousePosition);

            endWireDif = convertedMousePosition - endWire.position;
            if (endWireDif.magnitude < 0.33)
            {
                SetPosition(new Vector3(endWire.position.x * 1.2f, endWire.position.y, endWire.position.z));
                dragging = false;
                connected = true;
                SetVisibility(false);
            }
        }

    }

    void ResetPosition()
    {
        SetPosition(startPos);
        //NewLinePos(startPos);
    }

    void NewLinePos(Vector3 Linepos)
    {
        line.SetPosition(0, Linepos);
    }

    void SetPosition(Vector3 Lpos)
    {
            transform.position = Lpos;

            Vector3 positionDif = Lpos - line.transform.position;
            line.SetPosition(2, positionDif - new Vector3(tip, 0, 0));
            line.SetPosition(3, positionDif - new Vector3(end, 0, 0));
    }

    private void OnMouseDown()
    {
        dragging = true;
    }
    private void OnMouseUp()
    {
        dragging = false;
        if (!connected)
        {
            ResetPosition();
        }
    }

    public bool IsConnected()
    {
        return(connected);
    }

    public void SetConnected(bool pConnected)
    {
        connected = pConnected;
        if (!connected)
        {
            ResetPosition();
        }
    }

    public void SetVisibility(bool pVis)
    {
        sprite.enabled = pVis;
        vis.enabled = pVis;
    }

    void OnBecameInvisible()
    {
        scoreLogic.SetScore(5 * Dmod);
        Debug.Log(scoreLogic.GetScore());
    }

}
