//uScript Generated Code - Build 0.9.2255
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/lift_make_your_lift")]
public class lift_make_your_lift_Component : uScriptCode
{
   #pragma warning disable 414
   public lift_make_your_lift ExposedVariables = new lift_make_your_lift( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject _Person_Controller { get { return ExposedVariables._Person_Controller; } set { ExposedVariables._Person_Controller = value; } } 
   public UnityEngine.KeyCode BOTTOM { get { return ExposedVariables.BOTTOM; } set { ExposedVariables.BOTTOM = value; } } 
   public UnityEngine.KeyCode TOP { get { return ExposedVariables.TOP; } set { ExposedVariables.TOP = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.CMR" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
         {
            GameObject gameObject;
            gameObject = GameObject.Find( "First Person Controller" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
      }
   #endif
}
