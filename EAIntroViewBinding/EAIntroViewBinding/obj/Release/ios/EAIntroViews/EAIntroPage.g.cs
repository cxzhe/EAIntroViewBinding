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
	[Register("EAIntroPage", true)]
	public unsafe partial class EAIntroPage : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("EAIntroPage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EAIntroPage () : base (NSObjectFlag.Empty)
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
		protected EAIntroPage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal EAIntroPage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("page")]
		[CompilerGenerated]
		public static EAIntroPage Page ()
		{
			return  Runtime.GetNSObject<EAIntroPage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("page")));
		}
		
		[Export ("pageWithCustomView:")]
		[CompilerGenerated]
		public static EAIntroPage PageWithCustomView (global::UIKit.UIView customV)
		{
			if (customV == null)
				throw new ArgumentNullException ("customV");
			return  Runtime.GetNSObject<EAIntroPage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("pageWithCustomView:"), customV.Handle));
		}
		
		[Export ("pageWithCustomViewFromNibNamed:")]
		[CompilerGenerated]
		public static EAIntroPage PageWithCustomViewFromNibNamed (string nibName)
		{
			if (nibName == null)
				throw new ArgumentNullException ("nibName");
			var nsnibName = NSString.CreateNative (nibName);
			
			EAIntroPage ret;
			ret =  Runtime.GetNSObject<EAIntroPage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("pageWithCustomViewFromNibNamed:"), nsnibName));
			NSString.ReleaseNative (nsnibName);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Alpha {
			[Export ("alpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alpha"));
				}
			}
			
			[Export ("setAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAlpha:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BgColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BgColor {
			[Export ("bgColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bgColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bgColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BgColor_var = ret;
				return ret;
			}
			
			[Export ("setBgColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBgColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBgColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BgColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BgImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage BgImage {
			[Export ("bgImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bgImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bgImage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BgImage_var = ret;
				return ret;
			}
			
			[Export ("setBgImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBgImage:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBgImage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BgImage_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CustomView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView CustomView {
			[Export ("customView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomView_var = ret;
				return ret;
			}
			
			[Export ("setCustomView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Desc {
			[Export ("desc", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("desc")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("desc")));
				}
			}
			
			[Export ("setDesc:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDesc:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDesc:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_DescColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DescColor {
			[Export ("descColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("descColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("descColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DescColor_var = ret;
				return ret;
			}
			
			[Export ("setDescColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDescColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDescColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DescColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DescFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont DescFont {
			[Export ("descFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("descFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("descFont")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DescFont_var = ret;
				return ret;
			}
			
			[Export ("setDescFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDescFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDescFont:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DescFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat DescPositionY {
			[Export ("descPositionY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("descPositionY"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("descPositionY"));
				}
			}
			
			[Export ("setDescPositionY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setDescPositionY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setDescPositionY:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual VoidBlock OnPageDidAppear {
			[Export ("onPageDidAppear", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("onPageDidAppear"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("onPageDidAppear"));
				}
				return global::ObjCRuntime.Trampolines.NIDVoidBlock.Create (ret);
			}
			
			[Export ("setOnPageDidAppear:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDVoidBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOnPageDidAppear:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOnPageDidAppear:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual VoidBlock OnPageDidDisappear {
			[Export ("onPageDidDisappear", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("onPageDidDisappear"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("onPageDidDisappear"));
				}
				return global::ObjCRuntime.Trampolines.NIDVoidBlock.Create (ret);
			}
			
			[Export ("setOnPageDidDisappear:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDVoidBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOnPageDidDisappear:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOnPageDidDisappear:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual VoidBlock OnPageDidLoad {
			[Export ("onPageDidLoad", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("onPageDidLoad"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("onPageDidLoad"));
				}
				return global::ObjCRuntime.Trampolines.NIDVoidBlock.Create (ret);
			}
			
			[Export ("setOnPageDidLoad:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDVoidBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOnPageDidLoad:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOnPageDidLoad:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_PageView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView PageView {
			[Export ("pageView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShowTitleView {
			[Export ("showTitleView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showTitleView"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showTitleView"));
				}
			}
			
			[Export ("setShowTitleView:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowTitleView:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowTitleView:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Subviews_var;
		[CompilerGenerated]
		public virtual NSObject[] Subviews {
			[Export ("subviews", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subviews")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subviews")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Subviews_var = ret;
				return ret;
			}
			
			[Export ("setSubviews:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubviews:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubviews:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Subviews_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
			}
			
			[Export ("setTitle:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitle:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_TitleColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor TitleColor {
			[Export ("titleColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleColor_var = ret;
				return ret;
			}
			
			[Export ("setTitleColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TitleFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont TitleFont {
			[Export ("titleFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleFont")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleFont_var = ret;
				return ret;
			}
			
			[Export ("setTitleFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleFont:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat TitleIconPositionY {
			[Export ("titleIconPositionY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("titleIconPositionY"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleIconPositionY"));
				}
			}
			
			[Export ("setTitleIconPositionY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setTitleIconPositionY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setTitleIconPositionY:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TitleIconView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView TitleIconView {
			[Export ("titleIconView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleIconView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleIconView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleIconView_var = ret;
				return ret;
			}
			
			[Export ("setTitleIconView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleIconView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleIconView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleIconView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat TitlePositionY {
			[Export ("titlePositionY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("titlePositionY"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titlePositionY"));
				}
			}
			
			[Export ("setTitlePositionY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setTitlePositionY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setTitlePositionY:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BgColor_var = null;
				__mt_BgImage_var = null;
				__mt_CustomView_var = null;
				__mt_DescColor_var = null;
				__mt_DescFont_var = null;
				__mt_PageView_var = null;
				__mt_Subviews_var = null;
				__mt_TitleColor_var = null;
				__mt_TitleFont_var = null;
				__mt_TitleIconView_var = null;
			}
		}
	} /* class EAIntroPage */
}
