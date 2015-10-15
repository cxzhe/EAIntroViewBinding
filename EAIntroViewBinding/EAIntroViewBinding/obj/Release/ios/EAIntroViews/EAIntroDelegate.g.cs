//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace EAIntroViews {
	[Register("EAIntroDelegate", false)]
	[Model]
	public unsafe partial class EAIntroDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EAIntroDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected EAIntroDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal EAIntroDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("introDidFinish:")]
		[CompilerGenerated]
		public virtual void IntroDidFinish (EAIntroView introView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("intro:pageAppeared:withIndex:")]
		[CompilerGenerated]
		public virtual void IntroPageAppearedWithIndex (EAIntroView introView, EAIntroPage page, global::System.nuint pageIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("intro:pageEndScrolling:withIndex:")]
		[CompilerGenerated]
		public virtual void IntroPageEndScrollingWithIndex (EAIntroView introView, EAIntroPage page, global::System.nuint pageIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("intro:pageStartScrolling:withIndex:")]
		[CompilerGenerated]
		public virtual void IntroPageStartScrollingWithIndex (EAIntroView introView, EAIntroPage page, global::System.nuint pageIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class EAIntroDelegate */
}
