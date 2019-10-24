using UnityEngine; 

public class Zla_Odpowiedz : MonoBehaviour 
{ 
   public string poziomDoWczytania; 

   void ZlaOdpowiedz() 
   { 
       Application.LoadLevel(poziomDoWczytania); 
   } 
}