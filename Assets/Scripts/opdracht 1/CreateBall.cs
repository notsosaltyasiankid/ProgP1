using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

    public class CreateBall : MonoBehaviour
    {
        public GameObject Prefab;

        private float elapsedTime = 0f;

        private List<GameObject> balls = new List<GameObject>();

        private float ballsStart = 100;
    GameObject createball(Color c)
        {
            GameObject ball = Instantiate(Prefab, new Vector3(UnityEngine.Random.Range(-20,20), UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-20,20)), Quaternion.identity);
            balls.Add(ball);
            Material mat = ball.GetComponent<MeshRenderer>().material;

            if (mat.shader.name == "Universal Render Pipeline/Lit")
            {
                mat.SetColor("_BaseColor", c);
            }


            DestroyBall();
            return ball;
        }
        public void DestroyBall()
        {
            for (int i = 0; i < balls.Count; i++)
            {
                Destroy(balls[i],3f);
            }
        }
        
        public void SpawnAlotOfBalls()
    {
           
            List<GameObject> Secondballs = new List<GameObject>();

            for (int i = 0; i < ballsStart; i++)
                {
                float r = UnityEngine.Random.Range(0f, 1f);
                float g = UnityEngine.Random.Range(0f, 1f);
                float b = UnityEngine.Random.Range(0f, 1f);
                Color randColor = new Color(r, g, b, 1f);
                Debug.Log(randColor);
                GameObject newBall = createball(randColor);
                Secondballs.Add(newBall);
                }
    }
    private void Start()
        {
            SpawnAlotOfBalls();
        }

        public void SpawnBallsPerSec()
    {
            elapsedTime += Time.deltaTime;
            if (elapsedTime > 1f)
            {
            float r = UnityEngine.Random.Range(0f, 1f);
            float g = UnityEngine.Random.Range(0f, 1f);
            float b = UnityEngine.Random.Range(0f, 1f);
            Color randColor = new Color(r, g, b, 1f);
            GameObject newBall = createball(randColor);
            elapsedTime = 0f;
            }
    }
        void Update()
        {
        SpawnBallsPerSec();
        }
    }
