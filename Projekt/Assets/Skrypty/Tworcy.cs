using UnityEngine; 
using System.Collections; 

public class Tworcy : MonoBehaviour 
{ 

    //Wymiary przyciskow 
    private int szerokoscPrzycisku = 400; 
    private int wysokoscPrzycisku = 40; 
	private int szerokoscPrzycisku1 = 190; 
    private int wysokoscPrzycisku1 = 40; 
	private int szerokoscPrzycisku2 = 700;
	private int wysokoscPrzycisku2 = 40; 
	
	
	public Texture teksturaTla;

	void OnGUI() 
    { 
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height) , teksturaTla);
		
		
		 
		//przycisk Kamil Piechura
        GUI.Button ( new Rect(  
                            500 - (szerokoscPrzycisku / 2), 
                            10, 
                            szerokoscPrzycisku2, 
                            wysokoscPrzycisku2), 
                            "Tworcy"); 
	
		//przycisk Programowanie
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            110, 
                            szerokoscPrzycisku,
                            wysokoscPrzycisku), 
                            "Kamil Piechura"); 
		
		//przycisk Projektowanie poziomu
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            180, 
                            szerokoscPrzycisku,
                            wysokoscPrzycisku), 
                            "Programowanie"); 
		
		//przycisk Grafika
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            225, 
                            szerokoscPrzycisku,
                            wysokoscPrzycisku), 
                            "Projektowanie poziomu"); 
		
		
		
		
		//Optymalizacja
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            270, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Modelowanie"); 
							
							//przycisk Animacje
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            315, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Optymalizacja"); 
		
		
							
							//przycisk Animacje
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            360, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Grafika"); 
		
				
							//przycisk Animacje
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            405, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Animacje"); 
							
							//przycisk Filip Ociepka
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            505, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Filip Ociepka"); 
							
							//przycisk Modele
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            560, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Teksturowanie");
		
		//przycisk Modele
		GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            660, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Maciej Lados"); 
							
							//przycisk Wyjscie
        if(GUI.Button(new Rect(  
                            250 - (szerokoscPrzycisku / 10 ), 
                            660, 
                            szerokoscPrzycisku1, 
                            wysokoscPrzycisku1), 
                            "Wróæ")) 
		{
			Application.LoadLevel("Menu");
		}
		


		
	}
}	
