using UnityEditor;
using UnityEngine;

namespace Local.B.Editor
{
    public static class LocalBEditor
    {
        [MenuItem("Local/Say Hello from B")]
        public static void SayHello()
        {
            Debug.Log("Hello from LocalBEditor");
        }
    }
}
