using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHp : MonoBehaviour
{
    [SerializeField] Slider slider;
    public float hp = 20f;
    public float MaxHp = 20f;
    bool isRed = false;
    SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        MaxHp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hp / MaxHp;
        
        if( hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("GameWin");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp--;
            ColorChange();
        }
    }

    void ColorChange()
    {
        StopCoroutine("BossColor");
        StartCoroutine("BossColor");
    }

    IEnumerator BossColor()
    {
        _spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        _spriteRenderer.color = Color.white;
    }


    

    
}
