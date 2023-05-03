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

    //--------------------------
    protected virtual void Start(){
        //AddComponent
        spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        boxCollider2d = this.gameObject.AddComponent<BoxColider2D>();
        rigidbody2d = this.gameObject.AddComponent<Rigidbody2D>();
        animator = this.gameObject.AddComponent<Animator>()
    }

    protected virtual void Attack(){
        
    }
}