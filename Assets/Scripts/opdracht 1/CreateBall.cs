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

    private Color GenerateRandomColor()
    {
        float r = UnityEngine.Random.Range(0f, 1f);
        float g = UnityEngine.Random.Range(0f, 1f);
        float b = UnityEngine.Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }

    private Vector3 GenerateRandomPosition()
    {
        float x = UnityEngine.Random.Range(-20, 20);
        float y = UnityEngine.Random.Range(-10, 10);
        float z = UnityEngine.Random.Range(-20, 20);
        return new Vector3(x, y, z);
    }

    GameObject createball(Color c)
    {
        GameObject ball = Instantiate(Prefab, GenerateRandomPosition(), Quaternion.identity);
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
            Destroy(balls[i], 3f);
        }
    }

    public void SpawnAlotOfBalls()
    {
        List<GameObject> Secondballs = new List<GameObject>();

        for (int i = 0; i < ballsStart; i++)
        {
            Color randColor = GenerateRandomColor();
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
            Debug.Log("Spawned ball");
            Color randColor = GenerateRandomColor();
            GameObject newBall = createball(randColor);
            elapsedTime = 0f;
        }
    }

    void Update()
    {
        SpawnBallsPerSec();
    }
}
