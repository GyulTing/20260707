using UnityEngine;

public class Class_20260720 : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        player.Attack();
        player.Heal(10f);
        player.PrintHp();
        player.PrintName();
        player.AddScore(enemy.GetScore());
        Debug.Log(player.GetCurrentScore());

        enemy.Attack();
        enemy.PrintName();
        Debug.Log(enemy.GetScore());
    }
}

class Player
{
    private float currentHp = 80f;
    private float maxHp = 100f;
    private string playerName = "";
    private float currentScore = 0f;

    public enum playerClass
    {
        Knight,
        Wizard,
        Thief
    }

    public void GetClass()
    {
        
    }

    public void Attack()
    {
        Debug.Log("Player 공격함!");
    }

    public void Heal(float _amount)
    {
        Debug.Log("Player 체력 회복");

        float healedHp = currentHp + _amount;// 일단 먼저 체력 더해보고, 최대 체력 이상이면 최대체력으로 맞춤

        if (healedHp > maxHp)
        {
            currentHp = maxHp;
        }
        else
        {
            currentHp = healedHp;
        }
    }

    public void PrintHp()
    {
        Debug.Log("Player의 현재 체력 : " + currentHp);
    }

    public void PrintName()
    {
        Debug.Log("Player의 이름 : " + playerName);
    }

    public void AddScore(float _score)
    {
        currentScore += _score;
    }

    public float GetCurrentScore()
    {
        return currentScore;
    }
}

class Enemy
{
    private string enemyName = "악당";
    private float score = 100f;
    public void Attack()
    {
        Debug.Log("Enemy 공격함!");
    }

    public void PrintName()
    {
        Debug.Log("Enemy의 이름 : " + enemyName);
    }

    public float GetScore()
    {
        return score;
    }
}
