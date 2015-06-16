//uScript Generated Code - Build 0.9.2255
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class push : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.String local_12_System_String = "push";
   UnityEngine.Vector3 local_2_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_4_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_4_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_5 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AddForce logic_uScriptAct_AddForce_uScriptAct_AddForce_1 = new uScriptAct_AddForce( );
   UnityEngine.GameObject logic_uScriptAct_AddForce_Target_1 = null;
   UnityEngine.Vector3 logic_uScriptAct_AddForce_Force_1 = new Vector3( );
   System.Single logic_uScriptAct_AddForce_Scale_1 = (float) 10;
   System.Boolean logic_uScriptAct_AddForce_UseForceMode_1 = (bool) false;
   UnityEngine.ForceMode logic_uScriptAct_AddForce_ForceModeType_1 = UnityEngine.ForceMode.Force;
   bool logic_uScriptAct_AddForce_Out_1 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_11 = null;
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_11 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_11 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_11 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_11 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = null;
   UnityEngine.CharacterController event_UnityEngine_GameObject_Controller_0 = null;
   UnityEngine.Collider event_UnityEngine_GameObject_Collider_0 = null;
   UnityEngine.Rigidbody event_UnityEngine_GameObject_RigidBody_0 = null;
   UnityEngine.Transform event_UnityEngine_GameObject_Transform_0 = null;
   UnityEngine.Vector3 event_UnityEngine_GameObject_Point_0 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 event_UnityEngine_GameObject_Normal_0 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 event_UnityEngine_GameObject_MoveDirection_0 = new Vector3( );
   System.Single event_UnityEngine_GameObject_MoveLength_0 = (float) 0;
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_5 || false == m_RegisteredForEvents )
      {
         owner_Connection_5 = parentGameObject;
         if ( null != owner_Connection_5 )
         {
            {
               uScript_ProxyController component = owner_Connection_5.GetComponent<uScript_ProxyController>();
               if ( null == component )
               {
                  component = owner_Connection_5.AddComponent<uScript_ProxyController>();
               }
               if ( null != component )
               {
                  component.OnHit += Instance_OnHit_0;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_5 )
         {
            {
               uScript_ProxyController component = owner_Connection_5.GetComponent<uScript_ProxyController>();
               if ( null == component )
               {
                  component = owner_Connection_5.AddComponent<uScript_ProxyController>();
               }
               if ( null != component )
               {
                  component.OnHit += Instance_OnHit_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_5 )
      {
         {
            uScript_ProxyController component = owner_Connection_5.GetComponent<uScript_ProxyController>();
            if ( null != component )
            {
               component.OnHit -= Instance_OnHit_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AddForce_uScriptAct_AddForce_1.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11.SetParent(g);
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnHit_0(object o, uScript_ProxyController.ProxyControllerCollisionEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      event_UnityEngine_GameObject_Controller_0 = e.Controller;
      event_UnityEngine_GameObject_Collider_0 = e.Collider;
      event_UnityEngine_GameObject_RigidBody_0 = e.RigidBody;
      event_UnityEngine_GameObject_Transform_0 = e.Transform;
      event_UnityEngine_GameObject_Point_0 = e.Point;
      event_UnityEngine_GameObject_Normal_0 = e.Normal;
      event_UnityEngine_GameObject_MoveDirection_0 = e.MoveDirection;
      event_UnityEngine_GameObject_MoveLength_0 = e.MoveLength;
      //relay event to nodes
      Relay_OnHit_0( );
   }
   
   void Relay_OnHit_0()
   {
      local_4_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      local_2_UnityEngine_Vector3 = event_UnityEngine_GameObject_MoveDirection_0;
      Relay_In_11();
   }
   
   void Relay_In_1()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_AddForce_Target_1 = local_4_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_AddForce_Force_1 = local_2_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddForce_uScriptAct_AddForce_1.In(logic_uScriptAct_AddForce_Target_1, logic_uScriptAct_AddForce_Force_1, logic_uScriptAct_AddForce_Scale_1, logic_uScriptAct_AddForce_UseForceMode_1, logic_uScriptAct_AddForce_ForceModeType_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_11()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_GameObjectHasTag_GameObject_11 = local_4_UnityEngine_GameObject;
            
         }
         {
            List<System.String> properties = new List<System.String>();
            properties.Add((System.String)local_12_System_String);
            logic_uScriptCon_GameObjectHasTag_Tag_11 = properties.ToArray();
         }
      }
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11.In(logic_uScriptCon_GameObjectHasTag_GameObject_11, logic_uScriptCon_GameObjectHasTag_Tag_11);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11.HasTag;
      
      if ( test_0 == true )
      {
         Relay_In_1();
      }
   }
   
}
