using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{

    [SerializeField] private float timeToLose;
    [SerializeField, Range(0.1f, 2f)] private float timeToIncrease;

    private Slider slider;

    private bool isGameOver = false;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = timeToLose;
        slider.value = slider.maxValue;
        GameSystem.Instance.inputManager.OnHit += IncreaseLoseTime;
    }

    private void Update()
    {
        slider.value *= Time.deltaTime;
        if (slider.value <= slider.minValue && !isGameOver)
        {
            isGameOver = true;
            GameOver();
        }
    }

    private void IncreaseLoseTime(Vector2 obj)
    {
        slider.value += timeToIncrease;
    }

    private void GameOver()
    {
        //TODO
        GameSystem.Instance.GameOver();
        Debug.Log("GAME OVER!");
    }
}
