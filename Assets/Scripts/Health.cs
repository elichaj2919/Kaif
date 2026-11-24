using UnityEngine;
using UnityEngine.InputSystem;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float hp = 100f;
    [SerializeField]
    private UpdateUI updateUI;
    
    
    
    private bool isDead;

    private Animator anim;
    private PlayerInput playerInput;


    private void Start()
    {
        anim = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
        
        updateUI.UpdateHealth(hp);
    }

    private void ApplyDamage(float damage)
    {
        if (isDead) return;
        

        hp -= damage;

        updateUI.UpdateHealth(hp);

        if (hp <= 0)
        {
            isDead = true;
            hp = 0;
            anim.SetBool(name: "Death", isDead);
            playerInput.enabled = false;
            updateUI.ShowGameOverUI();

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
