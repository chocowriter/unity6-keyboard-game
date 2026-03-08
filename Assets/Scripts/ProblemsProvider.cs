using UnityEngine;

namespace KeyboardGame
{
    public class ProblemsProvider : MonoBehaviour
    {
        private string targetSentenceTest = "Hello, world!";

        private void Awake()
        {
            
        }

        public string GetAnswer()
        {
            return targetSentenceTest;
        }
    }
}