using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoSingleton<GameController>
{
    private Transform canvas;

    public Transform Canvas
    {
        get
        {
            if (canvas == null)
            {
                canvas = GameObject.Find("Canvas").transform;
            }
            return canvas;
        }
    }

    /// <summary>
    /// Æô¶¯¿ò¼Ü
    /// </summary>
    public override void Init()
    {
        new AppFacade();
    }
}
