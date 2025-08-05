using UnityEditor;
using UnityEngine;

namespace Local.A.Editor
{
    public static class LocalAEditor
    {
        [MenuItem("Local/Say Hello from A")]
        public static void SayHello()
        {
            Debug.Log("Hello from LocalAEditor");
        }
    }
}
