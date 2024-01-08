using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BezierCurve{
    public static Vector2 GetPoint(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t) {
        
        t = Mathf.Clamp01(t);

        float u = 1f - t;
        float tt = t * t;
        float uu = u * u;
        float uuu = uu * u;
        float ttt = tt * t;

        Vector2 point = uuu * p0;
        point += 3f * uu * t * p1;
        point += 3f * u * tt * p2;
        point += ttt * p3;

        return point;
    }
}
