using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesManager : MonoBehaviour
{
    public GameObject pipeModel;
    public Transform spawnPoint;
    public float intervalo;

    private float currentTime = 0f;

    void Start()
    {

    }

    // Update is called once per frame 

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > intervalo)
        {
                CreatPipe();
                currentTime = 0f;
            }
        }
        void CreatPipe()
        {
            Instantiate(pipeModel, spawnPoint.position, Quaternion.identity);
        }
    }

