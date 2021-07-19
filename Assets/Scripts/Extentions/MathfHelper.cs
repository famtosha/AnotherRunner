using UnityEngine;

public static class MathfHelper
{
    public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
    {
        Vector3 AB = b - a;
        Vector3 AV = value - a;
        return Vector3.Dot(AV, AB) / Vector3.Dot(AB, AB);
    }

    public static Vector3 PointOnLine(Vector3 a, Vector3 b, Vector3 p)
    {
        return a + Vector3.Project(p - a, b - a);
    }
}
