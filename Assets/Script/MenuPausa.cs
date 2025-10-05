using UnityEngine;
using UnityEngine.UI; 

public class MenuPausa : MonoBehaviour
{
	
	public GameObject pauseText;
	public GameObject pauseText2;
	public GameObject pausePanel;
	
	private bool pausa = false;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		if(Input.GetKeyDown(KeyCode.P)){
			
			if(pausa){
				
				pauseText.SetActive(true);
				pausePanel.SetActive(false);
				pauseText2.SetActive(false);
				Time.timeScale = 1f; 
				pausa = false;
				
			}else{
				
				pauseText.SetActive(false);
				pausePanel.SetActive(true);
				pauseText2.SetActive(true);
				Time.timeScale = 0f; 
				pausa = true;
				
			}
		}
        
    }
}
