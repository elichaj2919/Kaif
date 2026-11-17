using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float hp = 100f;
    [SerializeField]
    private UpdateUI updateUI;

    private bool isDead;

    private void Start()
    {
        updateUI.UpdateHealth(hp);
    }

    private void ApplyDamage(float damage)
    {
        if (isDead) return;
        

        hp -= damage;

        updateUI.UpdateHealth(hp);

        if (hp <= 0)
        {
            isDead=true;
            hp = 0;


            print("Потрачено");
        }
    }

    
     private void OnTriggerStay(Collider other)

    { 
        if (other.CompareTag("Damage"))
        {
            ApplyDamage(0.5f);
        }




    }
    
}
