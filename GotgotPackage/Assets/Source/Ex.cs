using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Ex
{
    #region Transform

    public static void SetPosX(this Transform t, float value)
    {
        var pos = t.position;
        pos.x = value;
        t.position = pos;
    }

    public static void SetPosY(this Transform t, float value)
    {
        var pos = t.position;
        pos.y = value;
        t.position = pos;
    }

    public static void SetPosZ(this Transform t, float value)
    {
        var pos = t.position;
        pos.z = value;
        t.position = pos;
    }

    public static void SetEulerAnglesY(this Transform t, float value)
    {
        var rot = t.eulerAngles;
        rot.y = value;
        t.eulerAngles = rot;
    }

    #endregion

    #region Image

    public static void SetOpacity(this Image i, float value)
    {
        var col = i.color;
        col.a = value;
        i.color = col;
    }

    #endregion
}