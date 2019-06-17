using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Image currentHealthbar;
    public Text ratioText;

    private float hitpoint = 100;
    private float maxHitpoint = 100;

    private void Start()
    {
        UpdateHealthbar();
    }

    private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("0") + '%';
    }

    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("Dead!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        UpdateHealthbar();
    }
    private void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
            hitpoint = maxHitpoint;

        UpdateHealthbar();
    }
}
