using System;
using UnityEngine;

namespace LDtkUnity.Editor
{
    public class GLClipScope : IDisposable
    {
        public GLClipScope(Rect rect)
        {
            GUI.BeginClip(rect);
        }
        public void Dispose()
        {
            GUI.EndClip();
        }
    }
}