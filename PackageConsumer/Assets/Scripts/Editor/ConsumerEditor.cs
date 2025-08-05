using UnityEditor;
using UnityEngine;

namespace Consumer.Editor
{
    public static class ConsumerEditor
    {
        [MenuItem("Local/Say Hello from Consumer")]
        public static void SayHello()
        {
            Debug.Log("Hello from ConsumerEditor");
        }
    }
}
