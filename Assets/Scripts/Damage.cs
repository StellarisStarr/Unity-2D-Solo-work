using Unity.VisualScripting;
using UnityEngine;

public class Damage : MonoBehaviour
{

    [SerializeField] Transform WeaponPivot;

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

        Vector2 Direction = MousePosition - transform.position;

        float Angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;

        WeaponPivot.rotation = Quaternion.Euler(0, 0, Angle);
    }
}
