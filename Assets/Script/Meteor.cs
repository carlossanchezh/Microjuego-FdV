using UnityEngine;

public class Meteor : MonoBehaviour
{
	
	public int tamaño = 2;
	public float velocidad = 2f;
	public GameObject meteorPrefab;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.CompareTag("Bullet")){
			
			if(tamaño>1){
				
				Dividir();
			}
			
		}
		
	}
	
	private void Dividir(){
		
		for(int i = 0; i < 2; i++)
    {
        GameObject hijo = Instantiate(meteorPrefab, transform.position, Quaternion.identity);

        float nuevaEscala = transform.localScale.x * 0.5f;
        hijo.transform.localScale = new Vector3(nuevaEscala, nuevaEscala, 1f);

        SphereCollider col = hijo.GetComponent<SphereCollider>();
        if (col != null) col.radius *= 0.5f;

        Meteor scriptHijo = hijo.GetComponent<Meteor>();
        scriptHijo.tamaño = tamaño - 1;
        scriptHijo.velocidad = velocidad;

        Vector2 direccion = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        Rigidbody rb = hijo.GetComponent<Rigidbody>();
        rb.linearVelocity = direccion * velocidad;
        
    }
		
	}
}
