// uScript Action Node
// (C) 2011 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Animation")]

[NodeCopyright("Copyright 2011 by Detox Studios LLC")]
[NodeToolTip("Returns the machine's IP address as a string")]
[NodeAuthor("Detox Studios LLC. Original node by xzlashed on the uScript Community Forum", "http://www.detoxstudios.com")]
[NodeHelp("http://www.uscript.net/docs/index.php?title=Node_Reference_Guide")]

[FriendlyName("Set Normalized Animation Position", "Sets the current position of the specified animation to a percentage of the whole animaiton (normalized position). For example, if you wish to have the animation play from middle of the animation, you would set the normalize position to 0.5 (50%).")]
public class uScriptAct_SetAnimationPosition : uScriptLogic {

	public delegate void uScriptEventHandler(object sender, System.EventArgs args);
	public event uScriptEventHandler Out;

   public void In(
      [FriendlyName("Target", "The GameObject containing the animtion clip.")]GameObject target,
      [FriendlyName("Animation", "The animation clip name you wish to use.")]string animationName,
      [FriendlyName("Normalized Position", "The normalized position (percentage) of the animation's start/play position you wish to set (0.0 - 1.0).")][DefaultValue(0)]float normalizedPosition
      )
	{
		if (normalizedPosition >= 0 && normalizedPosition <= 1)
			target.GetComponent<Animation>()[animationName].normalizedTime = normalizedPosition;
		else if (normalizedPosition < 0)
			target.GetComponent<Animation>()[animationName].normalizedTime = 0;
		else if (normalizedPosition > 1)
			target.GetComponent<Animation>()[animationName].normalizedTime = 1;
		if (Out != null) Out(this, new System.EventArgs());
	}
	
}
