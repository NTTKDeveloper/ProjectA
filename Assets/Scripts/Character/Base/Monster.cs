using System.Collection;
using System.Collection.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //Biến thuộc tính cơ bản của gameObject
    protected SpriteRenderer spriteRenderer;
    protected BoxColider2D boxCollider2d;
    protected Rigidbody2D rigidbody2d;
    protected Animator animator;
    //--------------------------
    // Thuộc tính cơ bản của Monster 
    protected float health;
    //Giá trị xác định xem quái có đc Spawn lại không
    protected bool isSpawning;
    //Biến kiểm tra xem có bị tấn công hay không?
    protected bool isAttack;
    //--------------------------
    protected virtual void Start(){
        //AddComponent
        spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        boxCollider2d = this.gameObject.AddComponent<BoxColider2D>();
        rigidbody2d = this.gameObject.AddComponent<Rigidbody2D>();
        animator = this.gameObject.AddComponent<Animator>()
    }

    //Hàm trừ máu khi bị tấn công. Hàm cần bổ sung Class: Weapon
    protected void minus_health(Weapon whatweapon){
	    if(isAttack){
            this.health = this.health - whatweapon.damage;
        }
    }

    protected virtual void Attack(){
        
    }
}
