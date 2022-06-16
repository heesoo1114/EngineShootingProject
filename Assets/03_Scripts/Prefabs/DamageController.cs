using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{

    [SerializeField] private int EnemyDamage;

    PlayerHP hpManager;

    
    private void Start()
    {
        hpManager = GameObject.Find("HPManager").GetComponent<PlayerHP>();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            TakeDamage(); 
        }
    }

    public void TakeDamage()
    {
        hpManager.playerHP = hpManager.playerHP - EnemyDamage;
        hpManager.UpdateHP();
        gameObject.SetActive(false);
    }
}
