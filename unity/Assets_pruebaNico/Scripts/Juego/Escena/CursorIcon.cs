using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorIcon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Texture2D Defaultcursor;
    public Texture2D AttackCursor;
    public Texture2D GrabCursor;
    public Texture2D SecondaryGrabCursor;


    public LayerMask Item;
    public LayerMask Enemy;
    public LayerMask Default;

    [Header("Menu:")]
    public MenusDeJuego Menus;


    void Start()
    {
        Cursor.SetCursor(Defaultcursor, Vector2.zero, CursorMode.Auto);

    }

    void FixedUpdate()
    {
        SetCursor();


    }
    void SetCursor()
    {
        if (!Menus.MenuAbierto)
        {

            Cursor.SetCursor(Defaultcursor, Vector2.zero, CursorMode.Auto);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, Item))
            {
                Cursor.SetCursor(GrabCursor, Vector2.zero, CursorMode.Auto);
                Cursor.SetCursor(SecondaryGrabCursor, Vector2.zero, CursorMode.Auto);
            }
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, Enemy))
            {
                Cursor.SetCursor(AttackCursor, Vector2.zero, CursorMode.Auto);
            }
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, Default))
            {
                Cursor.SetCursor(Defaultcursor, Vector2.zero, CursorMode.Auto);
            }
        }
        else
        {
            Cursor.SetCursor(Defaultcursor, Vector2.zero, CursorMode.Auto);
        }

    }

    private void WaitForSeconds(int v)
    {
        throw new NotImplementedException();
    }
}
