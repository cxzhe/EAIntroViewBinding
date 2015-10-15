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
	[Register("EARestrictedScrollView", true)]
	public unsafe partial class EARestrictedScrollView : global::UIKit.UIScrollView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("EARestrictedScrollView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EARestrictedScrollView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public EARestrictedScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected EARestrictedScrollView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal EARestrictedScrollView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_ContainedSubviews_var;
		[CompilerGenerated]
		public virtual NSObject[] ContainedSubviews {
			[Export ("containedSubviews", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("containedSubviews")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("containedSubviews")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContainedSubviews_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGPoint ContentOffset {
			[Export ("alignedContentOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("alignedContentOffset"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("alignedContentOffset"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("alignedContentOffset"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("alignedContentOffset"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alignedContentOffset"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("alignedContentOffset"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alignedContentOffset"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alignedContentOffset"));
					}
				}
				return ret;
			}
			
			[Export ("setAlignedContentOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setAlignedContentOffset:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setAlignedContentOffset:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGRect RestrictionArea {
			[Export ("restrictionArea", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("restrictionArea"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("restrictionArea"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("restrictionArea"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("restrictionArea"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("restrictionArea"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("restrictionArea"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("restrictionArea"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("restrictionArea"));
					}
				}
				return ret;
			}
			
			[Export ("setRestrictionArea:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setRestrictionArea:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("setRestrictionArea:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContainedSubviews_var = null;
			}
		}
		public partial class EARestrictedScrollViewAppearance : UIScrollView.UIScrollViewAppearance {
			protected internal EARestrictedScrollViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new EARestrictedScrollViewAppearance Appearance {
			get { return new EARestrictedScrollViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new EARestrictedScrollViewAppearance GetAppearance<T> () where T: EARestrictedScrollView {
			return new EARestrictedScrollViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new EARestrictedScrollViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new EARestrictedScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new EARestrictedScrollViewAppearance GetAppearance (UITraitCollection traits) {
			return new EARestrictedScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new EARestrictedScrollViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new EARestrictedScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new EARestrictedScrollViewAppearance GetAppearance<T> (UITraitCollection traits) where T: EARestrictedScrollView {
			return new EARestrictedScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new EARestrictedScrollViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: EARestrictedScrollView{
			return new EARestrictedScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class EARestrictedScrollView */
}
