//uScript Generated Code - Build 0.9.2255
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class lift_doors : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.String local_11_System_String = "lift_close";
   System.String local_15_System_String = "lift_open";
   System.Single local_16_System_Single = (float) 0;
   System.Single local_17_System_Single = (float) 0;
   System.Single local_19_System_Single = (float) 0;
   System.String local_2_System_String = "lift_open";
   System.Single local_21_System_Single = (float) 0;
   System.String local_24_System_String = "";
   System.String local_3_System_String = "lift_close";
   System.String local_30_System_String = "";
   UnityEngine.GameObject local_34_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_34_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_35_UnityEngine_GameObject = null;
   UnityEngine.GameObject local_35_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_0 = null;
   UnityEngine.GameObject owner_Connection_27 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_4 = null;
   System.String logic_uScriptAct_GetAnimationState_animationName_4 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_4;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_4;
   System.Single logic_uScriptAct_GetAnimationState_animLength_4;
   System.Single logic_uScriptAct_GetAnimationState_speed_4;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_4;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_4;
   bool logic_uScriptAct_GetAnimationState_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_5 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_5 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_5 = (float) 2;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_5 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_5 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_7 = null;
   System.String logic_uScriptAct_SetAnimationPosition_animationName_7 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_7 = (float) 0;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_9 = null;
   System.String logic_uScriptAct_SetAnimationPosition_animationName_9 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_9 = (float) 0;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_10 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_10 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_10 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_10 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_12 = null;
   System.String logic_uScriptAct_GetAnimationState_animationName_12 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_12;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_12;
   System.Single logic_uScriptAct_GetAnimationState_animLength_12;
   System.Single logic_uScriptAct_GetAnimationState_speed_12;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_12;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_12;
   bool logic_uScriptAct_GetAnimationState_Out_12 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_13 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_13 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_13 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_13 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_14 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_14 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_14 = (float) 2;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_14 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_14 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_18 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_18 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_18 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_18;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_18;
   bool logic_uScriptAct_SubtractFloat_Out_18 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_20 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_20 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_20 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_20;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_20;
   bool logic_uScriptAct_SubtractFloat_Out_20 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_23 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_23 = "";
   System.String logic_uScriptCon_CompareString_B_23 = "stop";
   bool logic_uScriptCon_CompareString_Same_23 = true;
   bool logic_uScriptCon_CompareString_Different_23 = true;
   //pointer to script instanced logic node
   uScriptCon_Gate logic_uScriptCon_Gate_uScriptCon_Gate_25 = new uScriptCon_Gate( );
   System.Boolean logic_uScriptCon_Gate_StartOpen_25 = (bool) true;
   System.Int32 logic_uScriptCon_Gate_AutoCloseCount_25 = (int) 0;
   System.Boolean logic_uScriptCon_Gate_IsOpen_25;
   //pointer to script instanced logic node
   uScriptCon_Gate logic_uScriptCon_Gate_uScriptCon_Gate_26 = new uScriptCon_Gate( );
   System.Boolean logic_uScriptCon_Gate_StartOpen_26 = (bool) true;
   System.Int32 logic_uScriptCon_Gate_AutoCloseCount_26 = (int) 0;
   System.Boolean logic_uScriptCon_Gate_IsOpen_26;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_29 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_29 = "";
   System.String logic_uScriptCon_CompareString_B_29 = "go";
   bool logic_uScriptCon_CompareString_Same_29 = true;
   bool logic_uScriptCon_CompareString_Different_29 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_32 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_32 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_32;
   bool logic_uScriptAct_GetParent_Out_32 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_33 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_33 = null;
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_33;
   bool logic_uScriptAct_GetParent_Out_33 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_TimesToTrigger_1 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_1 = null;
   UnityEngine.GameObject event_UnityEngine_GameObject_Sender_22 = null;
   System.String event_UnityEngine_GameObject_EventName_22 = "";
   UnityEngine.GameObject event_UnityEngine_GameObject_Sender_28 = null;
   System.String event_UnityEngine_GameObject_EventName_28 = "";
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_34_UnityEngine_GameObject_previous != local_34_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_34_UnityEngine_GameObject_previous = local_34_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_35_UnityEngine_GameObject_previous != local_35_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_35_UnityEngine_GameObject_previous )
         {
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_22;
               }
            }
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_28;
               }
            }
         }
         
         local_35_UnityEngine_GameObject_previous = local_35_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_35_UnityEngine_GameObject )
         {
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_35_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_22;
               }
            }
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_35_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_28;
               }
            }
         }
      }
      if ( null == owner_Connection_0 || false == m_RegisteredForEvents )
      {
         owner_Connection_0 = parentGameObject;
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_1;
               }
            }
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      if ( null == owner_Connection_27 || false == m_RegisteredForEvents )
      {
         owner_Connection_27 = parentGameObject;
         if ( null != owner_Connection_27 )
         {
            {
               uScript_Global component = owner_Connection_27.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_27.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_31;
                  component.uScriptLateStart += Instance_uScriptLateStart_31;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_34_UnityEngine_GameObject_previous != local_34_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_34_UnityEngine_GameObject_previous = local_34_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_35_UnityEngine_GameObject_previous != local_35_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_35_UnityEngine_GameObject_previous )
         {
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_22;
               }
            }
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_28;
               }
            }
         }
         
         local_35_UnityEngine_GameObject_previous = local_35_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_35_UnityEngine_GameObject )
         {
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_35_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_22;
               }
            }
            {
               uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_35_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_28;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_1;
               }
            }
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_27 )
         {
            {
               uScript_Global component = owner_Connection_27.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_27.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_31;
                  component.uScriptLateStart += Instance_uScriptLateStart_31;
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
      if ( null != local_35_UnityEngine_GameObject )
      {
         {
            uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
            if ( null != component )
            {
               component.OnCustomEvent -= Instance_OnCustomEvent_22;
            }
         }
         {
            uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
            if ( null != component )
            {
               component.OnCustomEvent -= Instance_OnCustomEvent_28;
            }
         }
      }
      if ( null != owner_Connection_0 )
      {
         {
            uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
               component.OnExitTrigger -= Instance_OnExitTrigger_1;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
            }
         }
      }
      if ( null != owner_Connection_27 )
      {
         {
            uScript_Global component = owner_Connection_27.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_31;
               component.uScriptLateStart -= Instance_uScriptLateStart_31;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.SetParent(g);
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_18.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_20.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_23.SetParent(g);
      logic_uScriptCon_Gate_uScriptCon_Gate_25.SetParent(g);
      logic_uScriptCon_Gate_uScriptCon_Gate_26.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_29.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_32.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_33.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.Finished += uScriptAct_PlayAnimation_Finished_5;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.Out += uScriptAct_SetAnimationPosition_Out_7;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.Out += uScriptAct_SetAnimationPosition_Out_9;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.Finished += uScriptAct_PlayAnimation_Finished_14;
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Out += uScriptCon_Gate_Out_25;
      logic_uScriptCon_Gate_uScriptCon_Gate_26.Out += uScriptCon_Gate_Out_26;
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
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.Update( );
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.Finished -= uScriptAct_PlayAnimation_Finished_5;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.Out -= uScriptAct_SetAnimationPosition_Out_7;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.Out -= uScriptAct_SetAnimationPosition_Out_9;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.Finished -= uScriptAct_PlayAnimation_Finished_14;
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Out -= uScriptCon_Gate_Out_25;
      logic_uScriptCon_Gate_uScriptCon_Gate_26.Out -= uScriptCon_Gate_Out_26;
   }
   
   void Instance_OnEnterTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_1( );
   }
   
   void Instance_OnExitTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_1( );
   }
   
   void Instance_WhileInsideTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_1( );
   }
   
   void Instance_OnCustomEvent_22(object o, uScript_CustomEvent.CustomEventBoolArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Sender_22 = e.Sender;
      event_UnityEngine_GameObject_EventName_22 = e.EventName;
      //relay event to nodes
      Relay_OnCustomEvent_22( );
   }
   
   void Instance_OnCustomEvent_28(object o, uScript_CustomEvent.CustomEventBoolArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Sender_28 = e.Sender;
      event_UnityEngine_GameObject_EventName_28 = e.EventName;
      //relay event to nodes
      Relay_OnCustomEvent_28( );
   }
   
   void Instance_uScriptStart_31(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_31( );
   }
   
   void Instance_uScriptLateStart_31(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_31( );
   }
   
   void uScriptAct_PlayAnimation_Finished_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_5( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_7( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_9(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_9( );
   }
   
   void uScriptAct_PlayAnimation_Finished_14(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_14( );
   }
   
   void uScriptCon_Gate_Out_25(object o, System.EventArgs e)
   {
      //fill globals
      //links to IsOpen = 0
      //relay event to nodes
      Relay_Out_25( );
   }
   
   void uScriptCon_Gate_Out_26(object o, System.EventArgs e)
   {
      //fill globals
      //links to IsOpen = 0
      //relay event to nodes
      Relay_Out_26( );
   }
   
   void Relay_OnEnterTrigger_1()
   {
      Relay_In_25();
   }
   
   void Relay_OnExitTrigger_1()
   {
      Relay_In_26();
   }
   
   void Relay_WhileInsideTrigger_1()
   {
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_4 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_4 = local_3_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4.In(logic_uScriptAct_GetAnimationState_target_4, logic_uScriptAct_GetAnimationState_animationName_4, out logic_uScriptAct_GetAnimationState_weight_4, out logic_uScriptAct_GetAnimationState_normalizedPosition_4, out logic_uScriptAct_GetAnimationState_animLength_4, out logic_uScriptAct_GetAnimationState_speed_4, out logic_uScriptAct_GetAnimationState_layer_4, out logic_uScriptAct_GetAnimationState_wrapMode_4);
      local_19_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_4;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_18();
      }
   }
   
   void Relay_Finished_5()
   {
      Relay_Open_26();
   }
   
   void Relay_In_5()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            properties.Add((UnityEngine.GameObject)owner_Connection_0);
            logic_uScriptAct_PlayAnimation_Target_5 = properties.ToArray();
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_5 = local_2_System_String;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.In(logic_uScriptAct_PlayAnimation_Target_5, logic_uScriptAct_PlayAnimation_Animation_5, logic_uScriptAct_PlayAnimation_SpeedFactor_5, logic_uScriptAct_PlayAnimation_AnimWrapMode_5, logic_uScriptAct_PlayAnimation_StopOtherAnimations_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_6()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_Out_7()
   {
      Relay_In_5();
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_7 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_7 = local_2_System_String;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_7 = local_17_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.In(logic_uScriptAct_SetAnimationPosition_target_7, logic_uScriptAct_SetAnimationPosition_animationName_7, logic_uScriptAct_SetAnimationPosition_normalizedPosition_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_8()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_Out_9()
   {
      Relay_In_14();
   }
   
   void Relay_In_9()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_9 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_9 = local_11_System_String;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_9 = local_16_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.In(logic_uScriptAct_SetAnimationPosition_target_9, logic_uScriptAct_SetAnimationPosition_animationName_9, logic_uScriptAct_SetAnimationPosition_normalizedPosition_9);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_10()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_10 = local_17_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.In(logic_uScriptCon_CompareFloat_A_10, logic_uScriptCon_CompareFloat_B_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
      if ( test_1 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_In_12()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_12 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_12 = local_15_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12.In(logic_uScriptAct_GetAnimationState_target_12, logic_uScriptAct_GetAnimationState_animationName_12, out logic_uScriptAct_GetAnimationState_weight_12, out logic_uScriptAct_GetAnimationState_normalizedPosition_12, out logic_uScriptAct_GetAnimationState_animLength_12, out logic_uScriptAct_GetAnimationState_speed_12, out logic_uScriptAct_GetAnimationState_layer_12, out logic_uScriptAct_GetAnimationState_wrapMode_12);
      local_21_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_12;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12.Out;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
   }
   
   void Relay_In_13()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_13 = local_16_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.In(logic_uScriptCon_CompareFloat_A_13, logic_uScriptCon_CompareFloat_B_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
      if ( test_1 == true )
      {
         Relay_In_9();
      }
   }
   
   void Relay_Finished_14()
   {
   }
   
   void Relay_In_14()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            properties.Add((UnityEngine.GameObject)owner_Connection_0);
            logic_uScriptAct_PlayAnimation_Target_14 = properties.ToArray();
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_14 = local_11_System_String;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.In(logic_uScriptAct_PlayAnimation_Target_14, logic_uScriptAct_PlayAnimation_Animation_14, logic_uScriptAct_PlayAnimation_SpeedFactor_14, logic_uScriptAct_PlayAnimation_AnimWrapMode_14, logic_uScriptAct_PlayAnimation_StopOtherAnimations_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_18()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_18 = local_19_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_18.In(logic_uScriptAct_SubtractFloat_A_18, logic_uScriptAct_SubtractFloat_B_18, out logic_uScriptAct_SubtractFloat_FloatResult_18, out logic_uScriptAct_SubtractFloat_IntResult_18);
      local_17_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_18;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_18.Out;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_In_20()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_20 = local_21_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_20.In(logic_uScriptAct_SubtractFloat_A_20, logic_uScriptAct_SubtractFloat_B_20, out logic_uScriptAct_SubtractFloat_FloatResult_20, out logic_uScriptAct_SubtractFloat_IntResult_20);
      local_16_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_20;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_20.Out;
      
      if ( test_0 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_OnCustomEvent_22()
   {
      local_24_System_String = event_UnityEngine_GameObject_EventName_22;
      Relay_In_23();
   }
   
   void Relay_In_23()
   {
      {
         {
            logic_uScriptCon_CompareString_A_23 = local_24_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_23.In(logic_uScriptCon_CompareString_A_23, logic_uScriptCon_CompareString_B_23);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_23.Same;
      
      if ( test_0 == true )
      {
         Relay_Close_25();
         Relay_Close_26();
      }
   }
   
   void Relay_Out_25()
   {
      Relay_In_6();
   }
   
   void Relay_In_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.In(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Open_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Open(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Close_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Close(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Toggle_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Toggle(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Out_26()
   {
      Relay_In_8();
   }
   
   void Relay_In_26()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_26.In(logic_uScriptCon_Gate_StartOpen_26, logic_uScriptCon_Gate_AutoCloseCount_26, out logic_uScriptCon_Gate_IsOpen_26);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Open_26()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_26.Open(logic_uScriptCon_Gate_StartOpen_26, logic_uScriptCon_Gate_AutoCloseCount_26, out logic_uScriptCon_Gate_IsOpen_26);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Close_26()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_26.Close(logic_uScriptCon_Gate_StartOpen_26, logic_uScriptCon_Gate_AutoCloseCount_26, out logic_uScriptCon_Gate_IsOpen_26);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Toggle_26()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_26.Toggle(logic_uScriptCon_Gate_StartOpen_26, logic_uScriptCon_Gate_AutoCloseCount_26, out logic_uScriptCon_Gate_IsOpen_26);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnCustomEvent_28()
   {
      local_30_System_String = event_UnityEngine_GameObject_EventName_28;
      Relay_In_29();
   }
   
   void Relay_In_29()
   {
      {
         {
            logic_uScriptCon_CompareString_A_29 = local_30_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_29.In(logic_uScriptCon_CompareString_A_29, logic_uScriptCon_CompareString_B_29);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_29.Same;
      
      if ( test_0 == true )
      {
         Relay_Open_25();
      }
   }
   
   void Relay_uScriptStart_31()
   {
      Relay_In_32();
   }
   
   void Relay_uScriptLateStart_31()
   {
   }
   
   void Relay_In_32()
   {
      {
         {
            logic_uScriptAct_GetParent_Target_32 = owner_Connection_27;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_32.In(logic_uScriptAct_GetParent_Target_32, out logic_uScriptAct_GetParent_Parent_32);
      local_34_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_32;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_34_UnityEngine_GameObject_previous != local_34_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_34_UnityEngine_GameObject_previous = local_34_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_32.Out;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_In_33()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_34_UnityEngine_GameObject_previous != local_34_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_34_UnityEngine_GameObject_previous = local_34_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_33 = local_34_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_33.In(logic_uScriptAct_GetParent_Target_33, out logic_uScriptAct_GetParent_Parent_33);
      local_35_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_33;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_35_UnityEngine_GameObject_previous != local_35_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            if ( null != local_35_UnityEngine_GameObject_previous )
            {
               {
                  uScript_CustomEvent component = local_35_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
                  if ( null != component )
                  {
                     component.OnCustomEvent -= Instance_OnCustomEvent_22;
                  }
               }
               {
                  uScript_CustomEvent component = local_35_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
                  if ( null != component )
                  {
                     component.OnCustomEvent -= Instance_OnCustomEvent_28;
                  }
               }
            }
            
            local_35_UnityEngine_GameObject_previous = local_35_UnityEngine_GameObject;
            
            //setup new listeners
            if ( null != local_35_UnityEngine_GameObject )
            {
               {
                  uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
                  if ( null == component )
                  {
                     component = local_35_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
                  }
                  if ( null != component )
                  {
                     component.OnCustomEvent += Instance_OnCustomEvent_22;
                  }
               }
               {
                  uScript_CustomEvent component = local_35_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
                  if ( null == component )
                  {
                     component = local_35_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
                  }
                  if ( null != component )
                  {
                     component.OnCustomEvent += Instance_OnCustomEvent_28;
                  }
               }
            }
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
