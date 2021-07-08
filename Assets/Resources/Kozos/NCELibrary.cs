﻿using System;
using UnityEngine;

namespace Resources.Kozos
{
    public class NCELibrary
    {
        public static float FindDegree(Vector2 From, Vector2 To)
        {
            var x = To.x - From.x;
            var y = To.y - From.y;
            float value = (float) ((Mathf.Atan2(x, y) / Math.PI) * 180f)+180f;
          // value += 180f;
            return value;
        }
    }
}