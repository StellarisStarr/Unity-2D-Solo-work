using UnityEngine;

public class Damage : MonoBehaviour
{

    [SerializeField] Transform WeaponPivot;
    [SerializeField] int DamageAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FaceMouse();
    }

    void FaceMouse()
    {
        Vector3 MousePosition = Camera.main.ScreenToWorldPoint( Input.mousePosition );

        Vector2 Direction = MousePosition - WeaponPivot.position;

        float Angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;

        WeaponPivot.rotation = Quaternion.Euler(0, 0, Angle);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(DamageAmount);
                Debug.Log("Enemy took damage!");
            }
        }
    }
}
