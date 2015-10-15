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
	[Register("EAIntroView", true)]
	public unsafe partial class EAIntroView : global::UIKit.UIView, global::UIKit.IUIScrollViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("EAIntroView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EAIntroView () : base (NSObjectFlag.Empty)
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
		public EAIntroView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected EAIntroView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal EAIntroView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:andPages:")]
		[CompilerGenerated]
		public EAIntroView (CGRect frame, NSObject[] pagesArray)
			: base (NSObjectFlag.Empty)
		{
			if (pagesArray == null)
				throw new ArgumentNullException ("pagesArray");
			var nsa_pagesArray = NSArray.FromNSObjects (pagesArray);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:andPages:"), frame, nsa_pagesArray.Handle), "initWithFrame:andPages:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:andPages:"), frame, nsa_pagesArray.Handle), "initWithFrame:andPages:");
			}
			nsa_pagesArray.Dispose ();
			
		}
		
		[Export ("hideWithFadeOutDuration:")]
		[CompilerGenerated]
		public virtual void HideWithFadeOutDuration (global::System.nfloat duration)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("hideWithFadeOutDuration:"), duration);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("hideWithFadeOutDuration:"), duration);
			}
		}
		
		[Export ("limitScrollingToPage:")]
		[CompilerGenerated]
		public virtual void LimitScrollingToPage (global::System.nuint lastPageIndex)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("limitScrollingToPage:"), lastPageIndex);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("limitScrollingToPage:"), lastPageIndex);
			}
		}
		
		[Export ("setCurrentPageIndex:animated:")]
		[CompilerGenerated]
		public virtual void SetCurrentPageIndex (global::System.nuint currentPageIndex, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("setCurrentPageIndex:animated:"), currentPageIndex, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("setCurrentPageIndex:animated:"), currentPageIndex, animated);
			}
		}
		
		[Export ("showFullscreen")]
		[CompilerGenerated]
		public virtual void ShowFullscreen ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showFullscreen"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showFullscreen"));
			}
		}
		
		[Export ("showFullscreenWithAnimateDuration:")]
		[CompilerGenerated]
		public virtual void ShowFullscreenWithAnimateDuration (global::System.nfloat duration)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("showFullscreenWithAnimateDuration:"), duration);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("showFullscreenWithAnimateDuration:"), duration);
			}
		}
		
		[Export ("showFullscreenWithAnimateDuration:andInitialPageIndex:")]
		[CompilerGenerated]
		public virtual void ShowFullscreenWithAnimateDuration (global::System.nfloat duration, global::System.nuint initialPageIndex)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat_nuint (this.Handle, Selector.GetHandle ("showFullscreenWithAnimateDuration:andInitialPageIndex:"), duration, initialPageIndex);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat_nuint (this.SuperHandle, Selector.GetHandle ("showFullscreenWithAnimateDuration:andInitialPageIndex:"), duration, initialPageIndex);
			}
		}
		
		[Export ("showInView:")]
		[CompilerGenerated]
		public virtual void ShowInView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showInView:"), view.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("showInView:"), view.Handle);
			}
		}
		
		[Export ("showInView:animateDuration:")]
		[CompilerGenerated]
		public virtual void ShowInView (global::UIKit.UIView view, global::System.nfloat duration)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nfloat (this.Handle, Selector.GetHandle ("showInView:animateDuration:"), view.Handle, duration);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nfloat (this.SuperHandle, Selector.GetHandle ("showInView:animateDuration:"), view.Handle, duration);
			}
		}
		
		[Export ("showInView:animateDuration:withInitialPageIndex:")]
		[CompilerGenerated]
		public virtual void ShowInView (global::UIKit.UIView view, global::System.nfloat duration, global::System.nuint initialPageIndex)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nfloat_nuint (this.Handle, Selector.GetHandle ("showInView:animateDuration:withInitialPageIndex:"), view.Handle, duration, initialPageIndex);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nfloat_nuint (this.SuperHandle, Selector.GetHandle ("showInView:animateDuration:withInitialPageIndex:"), view.Handle, duration, initialPageIndex);
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
		public virtual global::UIKit.UIViewContentMode BgViewContentMode {
			[Export ("bgViewContentMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIViewContentMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIViewContentMode) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("bgViewContentMode"));
					} else {
						ret = (global::UIKit.UIViewContentMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("bgViewContentMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIViewContentMode) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bgViewContentMode"));
					} else {
						ret = (global::UIKit.UIViewContentMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bgViewContentMode"));
					}
				}
				return ret;
			}
			
			[Export ("setBgViewContentMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setBgViewContentMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setBgViewContentMode:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setBgViewContentMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setBgViewContentMode:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint CurrentPageIndex {
			[Export ("currentPageIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("currentPageIndex"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentPageIndex"));
				}
			}
			
			[Export ("setCurrentPageIndex:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setCurrentPageIndex:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setCurrentPageIndex:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public EAIntroDelegate Delegate {
			get {
				return WeakDelegate as /**/EAIntroDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool EaseOutCrossDisolves {
			[Export ("easeOutCrossDisolves")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("easeOutCrossDisolves"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("easeOutCrossDisolves"));
				}
			}
			
			[Export ("setEaseOutCrossDisolves:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEaseOutCrossDisolves:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEaseOutCrossDisolves:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HideOffscreenPages {
			[Export ("hideOffscreenPages")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hideOffscreenPages"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideOffscreenPages"));
				}
			}
			
			[Export ("setHideOffscreenPages:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHideOffscreenPages:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHideOffscreenPages:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat MotionEffectsRelativeValue {
			[Export ("motionEffectsRelativeValue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("motionEffectsRelativeValue"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("motionEffectsRelativeValue"));
				}
			}
			
			[Export ("setMotionEffectsRelativeValue:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMotionEffectsRelativeValue:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMotionEffectsRelativeValue:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PageControl_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIPageControl PageControl {
			[Export ("pageControl", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIPageControl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIPageControl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageControl")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIPageControl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageControl")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageControl_var = ret;
				return ret;
			}
			
			[Export ("setPageControl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPageControl:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPageControl:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageControl_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat PageControlY {
			[Export ("pageControlY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pageControlY"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageControlY"));
				}
			}
			
			[Export ("setPageControlY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPageControlY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPageControlY:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Pages_var;
		[CompilerGenerated]
		public virtual NSObject[] Pages {
			[Export ("pages", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pages")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pages")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Pages_var = ret;
				return ret;
			}
			
			[Export ("setPages:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPages:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPages:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Pages_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollingEnabled {
			[Export ("scrollingEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("scrollingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollingEnabled"));
				}
			}
			
			[Export ("setScrollingEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual EARestrictedScrollView ScrollView {
			[Export ("scrollView", ArgumentSemantic.Retain)]
			get {
				EARestrictedScrollView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<EARestrictedScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollView")));
				} else {
					ret =  Runtime.GetNSObject<EARestrictedScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ScrollView_var = ret;
				return ret;
			}
			
			[Export ("setScrollView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScrollView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScrollView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ScrollView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowSkipButtonOnlyOnLastPage {
			[Export ("showSkipButtonOnlyOnLastPage")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showSkipButtonOnlyOnLastPage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showSkipButtonOnlyOnLastPage"));
				}
			}
			
			[Export ("setShowSkipButtonOnlyOnLastPage:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowSkipButtonOnlyOnLastPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowSkipButtonOnlyOnLastPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SkipButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton SkipButton {
			[Export ("skipButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("skipButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("skipButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SkipButton_var = ret;
				return ret;
			}
			
			[Export ("setSkipButton:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSkipButton:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSkipButton:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SkipButton_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual EAViewAlignment SkipButtonAlignment {
			[Export ("skipButtonAlignment", ArgumentSemantic.UnsafeUnretained)]
			get {
				EAViewAlignment ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (EAViewAlignment) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("skipButtonAlignment"));
					} else {
						ret = (EAViewAlignment) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("skipButtonAlignment"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (EAViewAlignment) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("skipButtonAlignment"));
					} else {
						ret = (EAViewAlignment) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("skipButtonAlignment"));
					}
				}
				return ret;
			}
			
			[Export ("setSkipButtonAlignment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setSkipButtonAlignment:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setSkipButtonAlignment:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setSkipButtonAlignment:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setSkipButtonAlignment:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat SkipButtonSideMargin {
			[Export ("skipButtonSideMargin")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("skipButtonSideMargin"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("skipButtonSideMargin"));
				}
			}
			
			[Export ("setSkipButtonSideMargin:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setSkipButtonSideMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setSkipButtonSideMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat SkipButtonY {
			[Export ("skipButtonY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("skipButtonY"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("skipButtonY"));
				}
			}
			
			[Export ("setSkipButtonY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setSkipButtonY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setSkipButtonY:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SwipeToExit {
			[Export ("swipeToExit")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("swipeToExit"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("swipeToExit"));
				}
			}
			
			[Export ("setSwipeToExit:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSwipeToExit:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSwipeToExit:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TapToNext {
			[Export ("tapToNext")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("tapToNext"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tapToNext"));
				}
			}
			
			[Export ("setTapToNext:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTapToNext:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTapToNext:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TitleView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView TitleView {
			[Export ("titleView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleView_var = ret;
				return ret;
			}
			
			[Export ("setTitleView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat TitleViewY {
			[Export ("titleViewY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("titleViewY"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleViewY"));
				}
			}
			
			[Export ("setTitleViewY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setTitleViewY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setTitleViewY:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseMotionEffects {
			[Export ("useMotionEffects")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useMotionEffects"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useMotionEffects"));
				}
			}
			
			[Export ("setUseMotionEffects:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseMotionEffects:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseMotionEffects:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint VisiblePageIndex {
			[Export ("visiblePageIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePageIndex"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visiblePageIndex"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_EAIntroDelegate EnsureEAIntroDelegate ()
		{
			var del = Delegate;
			if (del == null || (!(del is _EAIntroDelegate))){
				del = new _EAIntroDelegate ();
				Delegate = del;
			}
			return (_EAIntroDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _EAIntroDelegate : EAIntroViews.EAIntroDelegate { 
			public _EAIntroDelegate () { IsDirectBinding = false; }
			
			internal EventHandler introDidFinish;
			[Preserve (Conditional = true)]
			public override void IntroDidFinish (EAIntroViews.EAIntroView introView)
			{
				EventHandler handler = introDidFinish;
				if (handler != null){
					handler (introView, EventArgs.Empty);
				}
			}
			
			internal EventHandler<IntroViewPageIndexEventArgs> introPageAppearedWithIndex;
			[Preserve (Conditional = true)]
			public override void IntroPageAppearedWithIndex (EAIntroViews.EAIntroView introView, EAIntroViews.EAIntroPage page, nuint pageIndex)
			{
				EventHandler<IntroViewPageIndexEventArgs> handler = introPageAppearedWithIndex;
				if (handler != null){
					var args = new IntroViewPageIndexEventArgs (page, pageIndex);
					handler (introView, args);
				}
			}
			
			internal EventHandler<IntroViewPageIndexEventArgs> introPageEndScrollingWithIndex;
			[Preserve (Conditional = true)]
			public override void IntroPageEndScrollingWithIndex (EAIntroViews.EAIntroView introView, EAIntroViews.EAIntroPage page, nuint pageIndex)
			{
				EventHandler<IntroViewPageIndexEventArgs> handler = introPageEndScrollingWithIndex;
				if (handler != null){
					var args = new IntroViewPageIndexEventArgs (page, pageIndex);
					handler (introView, args);
				}
			}
			
			internal EventHandler<IntroViewPageIndexEventArgs> introPageStartScrollingWithIndex;
			[Preserve (Conditional = true)]
			public override void IntroPageStartScrollingWithIndex (EAIntroViews.EAIntroView introView, EAIntroViews.EAIntroPage page, nuint pageIndex)
			{
				EventHandler<IntroViewPageIndexEventArgs> handler = introPageStartScrollingWithIndex;
				if (handler != null){
					var args = new IntroViewPageIndexEventArgs (page, pageIndex);
					handler (introView, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler IntroDidFinish {
			add { EnsureEAIntroDelegate ().introDidFinish += value; }
			remove { EnsureEAIntroDelegate ().introDidFinish -= value; }
		}
		
		public event EventHandler<IntroViewPageIndexEventArgs> IntroPageAppearedWithIndex {
			add { EnsureEAIntroDelegate ().introPageAppearedWithIndex += value; }
			remove { EnsureEAIntroDelegate ().introPageAppearedWithIndex -= value; }
		}
		
		public event EventHandler<IntroViewPageIndexEventArgs> IntroPageEndScrollingWithIndex {
			add { EnsureEAIntroDelegate ().introPageEndScrollingWithIndex += value; }
			remove { EnsureEAIntroDelegate ().introPageEndScrollingWithIndex -= value; }
		}
		
		public event EventHandler<IntroViewPageIndexEventArgs> IntroPageStartScrollingWithIndex {
			add { EnsureEAIntroDelegate ().introPageStartScrollingWithIndex += value; }
			remove { EnsureEAIntroDelegate ().introPageStartScrollingWithIndex -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BgImage_var = null;
				__mt_PageControl_var = null;
				__mt_Pages_var = null;
				__mt_ScrollView_var = null;
				__mt_SkipButton_var = null;
				__mt_TitleView_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class EAIntroViewAppearance : UIView.UIViewAppearance {
			protected internal EAIntroViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new EAIntroViewAppearance Appearance {
			get { return new EAIntroViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new EAIntroViewAppearance GetAppearance<T> () where T: EAIntroView {
			return new EAIntroViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new EAIntroViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new EAIntroViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new EAIntroViewAppearance GetAppearance (UITraitCollection traits) {
			return new EAIntroViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new EAIntroViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new EAIntroViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new EAIntroViewAppearance GetAppearance<T> (UITraitCollection traits) where T: EAIntroView {
			return new EAIntroViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new EAIntroViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: EAIntroView{
			return new EAIntroViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class EAIntroView */
	
	
	//
	// EventArgs classes
	//
	public partial class IntroViewPageIndexEventArgs : EventArgs {
		public IntroViewPageIndexEventArgs (EAIntroViews.EAIntroPage page, nuint pageIndex)
		{
			this.Page = page;
			this.PageIndex = pageIndex;
		}
		public EAIntroViews.EAIntroPage Page { get; set; }
		public nuint PageIndex { get; set; }
	}
	
}
