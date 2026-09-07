using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [SerializeField] int HP;

    [SerializeField] Renderer model;

    Color colorOrig;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorOrig = model.material.color;
        GameManager.Instance.UpdateGameGoal(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {

        HP -= amount;

        if (HP <= 0)
        {
            Destroy(gameObject);
            GameManager.Instance.UpdateGameGoal(-1);
        }
        else
        {
            StartCoroutine(FlashRed());
        }
    }

    IEnumerator FlashRed()
    {
        model.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        model.material.color = colorOrig;
    }
}
