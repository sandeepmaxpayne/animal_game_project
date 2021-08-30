using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {


        private int score = 0;
        private int lives = 3;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void AddLives(int value)
        {
            lives += value;
            if (lives <= 0)
            {
                Debug.Log("Game Over");
                lives = 0;
            }
            Debug.Log($"Lives = {lives}");
        }
        public void AddScore(int value)
        {
            score += value;
            Debug.Log($"Score = {score}");
        }
    }
}